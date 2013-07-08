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
      public static byte[] SET_MODE_AM = new byte[] {};
      public static byte[] SET_MODE_LSB = new byte[] {};
      public static byte[] SET_MODE_ISB = new byte[] {};
      public static byte[] SET_MODE_USB = new byte[] {};
    }
}
