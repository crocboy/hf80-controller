 using System;
using System.Collections;
using System.Collections.Generic;
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

        public const byte ENABLE_TX = 0x10;
        public const byte DISABLE_TX = 0xEF;

        /* Bitmasks used for enabling certain modes */
        public const byte MODE_ENABLE_AM = 0x40;
        public const byte MODE_ENABLE_ISB = 0x28;
        public const byte MODE_ENABLE_CW = 0x30;
        public static byte[] MODE_ENABLE_USB = { 0x01, 0x20 };
        public static byte[] MODE_ENABLE_LSB = { 0x02, 0x20 };

        public const byte ENABLE_STATUS_RETURN = 0x3F;

        #region Mode Methods
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

            current[1] = (byte)(current[1] & ENABLE_STATUS_RETURN);  // Enable status return
            return current;
        }

        #endregion

        #region Frequency Methods

        /* Return the frequency message for the given frequency (in hertz) */
        public static byte[] GetFrequencyMessage(int freq)
        {
            if (freq > 29999999 || freq <= 0)
                return null;

            byte[] data = new byte[5];
            data[0] = WORD_ONE_START;

            byte[] digits = GetDigitArray(freq);

            /* Apply the first digit as a direct assignment */
            /* Mask the rest of the digits after they are shifted to the left 4 bits - this forms the BCD */
            data[4] = digits[0];
            data[4] = (byte)(data[4] | (digits[1] << 4));

            data[3] = digits[2];
            data[3] = (byte)(data[3] | (digits[3] << 4));

            data[2] = digits[4];
            data[2] = (byte)(data[2] | (digits[5] << 4));

            data[1] = digits[6];

            /* If there is a digit 8, mask it */
            if(digits.Length == 8)
                data[1] = (byte)(data[1] | (digits[7] << 4));
            
            data[1] = (byte)(data[1] & ENABLE_STATUS_RETURN); // Enable status return
            return data;
        }

        /* Return the 4-bit version of the given digit (0-9) */
        /* Used as a bitmask when creating the frequency message */
        public byte GetMask(byte digit)
        {
            return 0;
        }

        /* Convert an integer to an array of its digits.  Lowest digit first. */
        public static byte[] GetDigitArray(int n)
        {
            if (n == 0) return new byte[1] { 0 };

            var digits = new List<byte>();

            for (; n != 0; n /= 10)
                digits.Add((byte)(n % 10));

            return digits.ToArray();
        }

        #endregion
    }
}
