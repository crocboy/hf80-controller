 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HF80
{
    /* This class provides methods for generating and accessing raw messages, intended to be sent over a SerialPort to the HF80 */
    /* All methods and fields are static, so no instance of Message is needed */
    class Message
    {
        public const HF80Address = 3; // The address of the HF80
        
        /* Defines the first character in each word */
        public const byte WORD_ONE_START   = 0xC0 | HF80Address;
        public const byte WORD_TWO_START   = 0xD0 | HF80Address;
        public const byte WORD_THREE_START = 0xE0 | HF80Address;
        public const byte WORD_FOUR_START  = 0xF0 | HF80Address;
        
        public static byte[] SET_MODE_AM = new byte[] {};
        public static byte[] SET_MODE_LSB = new byte[] {};
        public static byte[] SET_MODE_ISB = new byte[] {};
        public static byte[] SET_MODE_USB = new byte[] {};
    }
}
