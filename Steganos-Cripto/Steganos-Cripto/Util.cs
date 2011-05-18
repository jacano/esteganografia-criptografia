﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Steganos_Cripto
{
    class Util
    {
        

        public static byte[] XorMessageWithKey(byte[] message, string key)
        {
            byte[] res = new byte[message.Length];
            
            for (int i = 0; i < message.Length; i++ )
            {
                res[i] = (byte)(message[i] ^ key[i % key.Length]);
            }

            return res;
        }

        public static byte[] ToByteArray(BitArray bits)
        {
            int numBytes = bits.Count / 8;
            if (bits.Count % 8 != 0) numBytes++;

            byte[] bytes = new byte[numBytes];
            int byteIndex = 0, bitIndex = 0;

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i])
                    bytes[byteIndex] |= (byte)(1 << (7 - bitIndex));

                bitIndex++;
                if (bitIndex == 8)
                {
                    bitIndex = 0;
                    byteIndex++;
                }
            }

            return bytes;
        }
    }
}
