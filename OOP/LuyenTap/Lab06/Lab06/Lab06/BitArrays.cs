using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class BitArrays
    {
        public static void MyBitArray()
        {
            BitArray bitArray = new BitArray(8);

            bitArray.Set(1, true);
            bitArray.Set(2, false);
            bitArray.Set(3, false);


            Console.WriteLine("\nHien thi cac bit trong BitArray");
            Console.WriteLine("BitArray: " + GetBitsAsString(bitArray));

            bitArray.Not();

            Console.WriteLine("\nDao nguoc bit trong BitArray");
            Console.WriteLine("BitArray: " + GetBitsAsString(bitArray));
        }


        static string GetBitsAsString(BitArray bits)
        {
            char[] bitChars = new char[bits.Length];
            for (int i = 0; i < bits.Length; i++)
            {
                bitChars[i] = bits[i] ? '1' : '0';
            }
            return new string(bitChars);
        }
    }
}
