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
        /* Configuration settings */
        public static int HF80_Baud = 9600;
        public static int HF80_DataBits = 8;
        public static StopBits HF80_StopBits = StopBits.None;
        public static Handshake HF80_Handshake = Handshake.None;


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
                port = new SerialPort(this.PortName)
                {
                    BaudRate = HF80_Baud,
                    StopBits = HF80_StopBits,
                    DataBits = HF80_DataBits,
                    Handshake = HF80_Handshake
                };

                return true;
            }
            catch (Exception e)
            {
                // Print exception 
                return false;
            }
        }
    }
}
