using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO.Ports;

namespace HF80
{
    /* Class "Radio" manages the serial communication with the HF80 */
    /* It also provides easy-to-use methods for changing frequency, transmitting, etc */
    /* Most messages are provided via the "Message" class */
    class Radio
    {
        /* Static constants for radio configuration */
        public const int MAX_FREQUENCY = 29999999;
        public const int MIN_FREQUENCY =  1000000;

        /* Static constants used for changing various settings */
        public const int MODE_AM  = 0;
        public const int MODE_LSB = 1;
        public const int MODE_ISB = 2;
        public const int MODE_USB = 3;
        public const int MODE_CW  = 4;

        /* Public variables */
        public bool IsLocal = false;

        /* Event handling variables */
        public delegate void OnPrint(String message);
        public event OnPrint onPrint;
        public delegate void OnLocalChanged(bool local);
        public event OnLocalChanged onLocalChanged;

        /* Instance variables */
        private SerialPort port;
        private String PortName;

        /// <summary>
        /// Public constructor for the Radio class
        /// </summary>
        /// <param name="portName">The serial port name of the radio (ie, "COM7")</param>
        public Radio(String portName)
        {
            this.PortName = portName;
        }


        /// <summary>
        /// Attempt to connect to the radio.
        /// </summary>
        /// <returns>Outcome of the operation</returns>
        public bool Connect()
        {
            /* Configure SerialPort */
            try
            {
                /* Set the SerialPort config settings */
                port = new SerialPort(this.PortName)
                {
                    BaudRate = 9600,
                    StopBits = StopBits.One,
                    DataBits = 8,
                    Handshake = Handshake.None,
                    Parity = Parity.Odd
                };

                port.Open();
                Flush();

                port.DiscardInBuffer();
                port.DiscardOutBuffer();

                if (CheckForLocal())
                    return false;

                return true;
            }
            catch (Exception e)
            {
                Print(e.ToString()); 
                port = null;
                return false;
            }
        }

        /// <summary>
        /// Set the frequency of the radio.
        /// </summary>
        /// <param name="frequency">Desired frequency in hertz.</param>
        /// <returns>Outcome of the operation.</returns>
        public bool SetFrequency(int frequency)
        {
            if (CheckForLocal())
                return false;

            if (frequency < MIN_FREQUENCY || frequency > MAX_FREQUENCY)
                return false;

            byte[] data = Message.GetFrequencyMessage(frequency);

            Write(data);

            byte[] response = ReadResponse();

            /* Re-enable status return and then compare the two, byte by byte */
            /* If two bytes are unequal, it will return false */
            response[1] = (byte)(response[1] & Message.ENABLE_STATUS_RETURN);

            for (int i = 1; i < response.Length; i++)
                if (data[i] != response[i])
                    return false;

            return true;
        }

        /// <summary>
        /// Set the operating mode of the radio.
        /// </summary>
        /// <param name="mode">The desired mode (A constant defined in the Radio class)</param>
        /// <returns>Outcome of the operation</returns>
        public bool SetMode(int mode)
        {
            try
            {
                Flush();

                //if (CheckForLocal())
                // return false;

                /* Find what mode the user wishes to switch to, and send the proper message over the serial port */
                byte[] currentStatus = GetStatus(2);

                switch (mode)
                {
                    case MODE_CW:
                        Write(Message.GetModeMessage(MODE_CW, currentStatus));
                        break;
                    case MODE_AM:
                        Write(Message.GetModeMessage(MODE_AM, currentStatus));
                        break;
                    case MODE_LSB:
                        Write(Message.GetModeMessage(MODE_LSB, currentStatus));
                        break;
                    case MODE_ISB:
                        Write(Message.GetModeMessage(MODE_ISB, currentStatus));
                        break;
                    case MODE_USB:
                        Write(Message.GetModeMessage(MODE_USB, currentStatus));
                        break;
                }

                /* Read the radio's response */
                byte[] response = ReadResponse();

                if (response[3] == currentStatus[3] && response[4] == currentStatus[4])
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                Print(e.ToString());
                return false;
            }
        }


        /* Attempt to print via the OnPrint event */
        private void Print(String message)
        {
            if (onPrint != null)
                onPrint(message);
        }

        /// <summary>
        /// Disconnect the Radio object and clean up resources.
        /// </summary>
        public void Disconnect()
        {
            if (port != null)
            {
                ForceTX(false); // Force key up for safety reasons
                port.Close();
            }
        }

        /// <summary>
        /// Write data to the SerialPort
        /// </summary>
        /// <param name="data">byte[] to be written</param>
        private void Write(byte[] data)
        {
            if(port != null)
                port.Write(data, 0, data.Length);
        }


        /* Get the response for the specified word */
        private byte[] GetStatus(int word)
        {
            if (CheckForLocal())
                throw new LocalModeException();

            if (word > 4 || word < 1)
                return null;

            byte[] sendData = Message.STATUS_MESSAGES[word - 1];
            Write(sendData);

            return ReadResponse();
        }

        /// <summary>
        /// Get a bit-level representation of Word 5
        /// </summary>
        /// <returns>An array of five bit arrays, each representing a character.</returns>
        private BitArray[] GetMasterStatus()
        {
            try
            {
                Flush();
                
                byte[] sendData = Message.STATUS_MESSAGES[3];
                port.Write(sendData, 0, sendData.Length);

                byte[] data = new byte[5];

                for (int i = 0; i < 5; i++)
                    data[i] = (byte)port.ReadByte();

                BitArray one = new BitArray(new byte[] { data[0] });
                BitArray two = new BitArray(new byte[] { data[1] });
                BitArray three = new BitArray(new byte[] { data[2] });
                BitArray four = new BitArray(new byte[] { data[3] });
                BitArray five = new BitArray(new byte[] { data[4] });

                return new BitArray[] { one, two, three, four, five };
            }
            catch (Exception e)
            {
                Print("Could not get Master status: " + e);
                return null;
            }
        }

        /// <summary>
        /// Refresh the value of 'IsLocal' and raise the OnLocalChanged event if necessary.
        /// </summary>
        /// <returns>True if the radio is in local mode, false otherwise.</returns>
        public bool CheckForLocal()
        {
            Flush();

            BitArray[] chars = GetMasterStatus();
            bool localNow = chars[4][1];

            if (IsLocal != localNow) // 2nd bit of 5th character
            {
                if (onLocalChanged != null)
                    onLocalChanged(localNow);

                IsLocal = localNow;
            }

            return IsLocal;
        }


        /// <summary>
        /// Set the status of the transmitting key.
        /// </summary>
        /// <param name="tx">The desired state of the TX key</param>
        /// <returns>The outcome of the operation</returns>
        public bool SetTX(bool tx)
        {
            Flush();

            if (CheckForLocal())
                return false;

            byte[] status = GetStatus(4);
            status[1] = (byte)(status[1] & Message.DISABLE_TX);  // Erase current TX settings

            if(tx)
                status[1] = (byte)(status[1] | Message.ENABLE_TX);

            Write(status);

            return true;
        }

        /// <summary>
        /// Force the state of the TX key (no validation is performed).  Used when we need to force the radio key up.
        /// </summary>
        /// <param name="tx">The state of the TX key</param>
        public void ForceTX(bool tx)
        {
            Flush();
            byte[] status = { Message.WORD_FOUR_START , 0 };
            status[1] = (byte)(status[1] & Message.DISABLE_TX);  // Erase current TX settings

            if (tx)
                status[1] = (byte)(status[1] | Message.ENABLE_TX);

            Write(status);
        }


        /// <summary>
        /// Set the state of the LSB AGC
        /// </summary>
        /// <param name="state">The desired state.</param>
        /// <returns>Outcome of the operation</returns>
        public bool SetLsbAgc(bool state)
        {
            if (CheckForLocal())
                return false;

            return false;
        }


        /// <summary>
        /// Set the state of the USB AGC
        /// </summary>
        /// <param name="state">The desired state.</param>
        /// <returns>Outcome of the operation</returns>
        public bool SetUsbAgc(bool state)
        {
            if (CheckForLocal())
                return false;

            return false;
        }

        /* Read a 5-byte response from the port */
        private byte[] ReadResponse()
        {
            try
            {
                byte[] data = new byte[5];

                for (int i = 0; i < 5; i++)
                    data[i] = (byte)port.ReadByte();

                return data;
            }
            catch (Exception e)
            {
                Print(e.ToString());
                return null;
            }
        }

        /// <summary>
        /// Flush the input buffer
        /// </summary>
        private void FlushIn()
        {
            if (port != null)
                port.DiscardInBuffer();
        }

        /// <summary>
        /// Flush the output buffer
        /// </summary>
        private void FlushOut()
        {
            if (port != null)
                port.DiscardOutBuffer();
        }

        /// <summary>
        /// Flush the input and output buffers
        /// </summary>
        private void Flush()
        {
            FlushIn();
            FlushOut();
        }
    }

    /// <summary>
    /// Exception thrown if radio is in local mode
    /// </summary>
    public class LocalModeException : Exception
    {
    }
}
