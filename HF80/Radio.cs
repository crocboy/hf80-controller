using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace HF80
{
    /* Class "Radio" manages the serial communication with the HF80 */
    /* It also provides easy-to-use methods for changing frequency, transmitting, etc */
    /* Most messages are provided via the "Message" class */
    class Radio
    {
        /* Static constants used for changing various settings */
        public const int MODE_AM  = 0;
        public const int MODE_LSB = 1;
        public const int MODE_ISB = 2;
        public const int MODE_USB = 3;
        public const int MODE_CW  = 4;

        /* Event handling variables */
        public delegate void OnPrint(String message);
        public event OnPrint onPrint;

        /* Instance variables */
        private SerialPort port;
        private String PortName;

        /* Constructor: Provide port name */
        public Radio(String portName)
        {
            this.PortName = portName;
        }


        /* Attempt to connect to the SerialPort given by the portName passed into the constructor */
        /* Return the status of the operation */
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

                return true;
            }
            catch (Exception e)
            {
                Print(e.ToString()); 
                port = null;
                return false;
            }
        }

        /* Set the frequency */
        public bool SetFrequency(int frequency)
        {
            byte[] data = Message.GetFrequencyMessage(frequency);

            Write(data);

            byte[] response = GetStatus(1);

            return true;
        }

        /* Change the mode of the radio */
        public bool SetMode(int mode)
        {
            /* Find what mode the user wishes to switch to, and send the proper message over the serial port */
            byte[] currentStatus = GetStatus(2);

            switch (mode)
            {
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


        /* Attempt to print via the OnPrint event */
        public void Print(String message)
        {
            if (onPrint != null)
                onPrint(message);
        }

        /* Close the SerialPort */
        public void Close()
        {
            if (port != null)
                port.Close();
        }

        /* Write the byte[] to the port, at an automatic offset of 0.  This is basically a shortcut method */
        private void Write(byte[] data)
        {
            if(port != null)
            {
                port.Write(data, 0, data.Length);
            }
        }


        /* Get the response for the specified word */
        private byte[] GetStatus(int word)
        {
            if (word > 4 || word < 1)
                return null;

            byte[] sendData = Message.STATUS_MESSAGES[word - 1];
            Write(sendData);

            return ReadResponse();
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
                return null;
            }
        }
    }
}
