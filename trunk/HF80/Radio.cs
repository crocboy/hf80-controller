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
        public const int MODE_AM = 0;
        public const int MODE_LSB = 1;
        public const int MODE_ISB = 2;
        public const int MODE_USB = 3;


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
                    Parity = Parity.None
                };

                port.DataReceived += OnDataReceived;

                return true;
            }
            catch (Exception e)
            {
                // Print exception 
                port = null;
                return false;
            }
        }

        /* Change the mode of the radio */
        public void SetMode(int mode)
        {
            /* Find what mode the user wishes to switch to, and send the proper message over the serial port */
            switch (mode)
            {
                case MODE_AM:
                    Write(Message.SET_MODE_AM);
                    break;
                case MODE_LSB:
                    Write(Message.SET_MODE_LSB);
                    break;
                case MODE_ISB:
                    Write(Message.SET_MODE_ISB);
                    break;
                case MODE_USB:
                    Write(Message.SET_MODE_USB);
                    break;
            }
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

        /* Called every time new data is received */
        public void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Console.WriteLine("");
        }
    }
}
