 using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace HF80
{
    /* This class provides methods for generating and accessing raw messages, intended to be sent over a SerialPort to the HF80 */
    /* All methods and fields are static, so no instance of Message is needed */
    class Message
    {
        public const int HF80Address = 3; // The address of the HF80
        
        /* Defines the first character in each word */
        public const byte WORD_ONE_START   = 0xC0 | HF80Address;
        public const byte WORD_TWO_START   = 0xD0 | HF80Address;
        public const byte WORD_THREE_START = 0xE0 | HF80Address;
        public const byte WORD_FOUR_START  = 0xF0 | HF80Address;
        
        /* Messages for querying status */
        public static byte[] WORD_ONE_STATUS   = {WORD_ONE_START, 0x80};
        public static byte[] WORD_TWO_STATUS = { WORD_TWO_START, 0x80 };
        public static byte[] WORD_THREE_STATUS = { WORD_THREE_START, 0x80 };
        public static byte[] WORD_FOUR_STATUS = { WORD_FOUR_START, 0x80 };
        public static byte[][] STATUS_MESSAGES = { WORD_ONE_STATUS, WORD_TWO_STATUS, WORD_THREE_STATUS, WORD_FOUR_STATUS };

        /* Bitmasks used for zeroing certain bits */
        public const byte ZERO_MODE_CHAR_5 = 0x07;
        public const byte ZERO_MODE_CHAR_4 = 0xFC;

        /* Bitmasks used for enabling certain modes */
        public const byte MODE_ENABLE_AM = 0x40;
        public const byte MODE_ENABLE_ISB = 0x28;
        public const byte MODE_ENABLE_CW = 0x30;
        public static byte[] MODE_ENABLE_USB = { 0x01, 0x20 };
        public static byte[] MODE_ENABLE_LSB = { 0x02, 0x20 };

        public const byte ENABLE_STATUS_RETURN = 0x80;

        /* Return a message that sets the mode of the radio to the given mode.  Pass in a status message representing the current status. */
        public static byte[] GetModeMessage(int mode, byte[] current)
        {
            if (current.Length != 5)
                return null;

            /* Zero-out only bits used for setting the mode */
            current[3] = (byte)(current[3] & ZERO_MODE_CHAR_4);
            current[4] = (byte) (current[4] & ZERO_MODE_CHAR_5);

            /* Set the mode bits */
            switch (mode)
            {
                case Radio.MODE_AM:
                    current[4] = (byte) (current[4] | MODE_ENABLE_AM);
                    break;
                case Radio.MODE_USB:
                    current[3] = (byte)(current[3] | MODE_ENABLE_USB[0]);
                    current[4] = (byte)(current[4] | MODE_ENABLE_USB[1]);
                    break;
                case Radio.MODE_ISB:
                    current[4] = (byte)(current[4] | MODE_ENABLE_ISB);
                    break;
                case Radio.MODE_LSB:
                    current[3] = (byte)(current[3] | MODE_ENABLE_LSB[0]);
                    current[4] = (byte)(current[4] | MODE_ENABLE_LSB[1]);
                    break;
                case Radio.MODE_CW:
                    current[4] = (byte)(current[4] & MODE_ENABLE_CW);
                    break;
            }

            current[1] = 0x80; // (byte)(current[1] & ENABLE_STATUS_RETURN);  // Enable status return
            return current;
        }

        /* Return the mode that the status message indicates */
        public static int GetMode(byte[] message)
        {
            if (message.Length != 5)
                return -1;

            BitArray four = new BitArray(new byte[] { message[3] });
            BitArray five = new BitArray(new byte[] { message[4] });

            bool[] data = new bool[8];
            five.CopyTo(data, 0);

            if (five[6])
                return Radio.MODE_AM;
            else if (five[5] && five[3])
                return Radio.MODE_ISB;
            else if (five[5] && five[4])
                return Radio.MODE_CW;
            else if (five[5] && four[0])
                return Radio.MODE_USB;
            else if (five[5] && four[1])
                return Radio.MODE_USB;

            return -1;
        }
    }
}
