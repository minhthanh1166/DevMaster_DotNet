using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];
            try
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write("a[{0}]:", i + 1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                }
            }
            catch (FormatException ex)
            {
                //Console.WriteLine("Error: " + ex);
                Console.WriteLine("Khong duoc nhap ky tu cho mang so!");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap gia tri ngoai 0-255");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Khong duoc nhap qua pham vi cua mang");
            }

            Console.WriteLine("\nIn mang");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

            Console.ReadLine();
        }
    }
}
