using System;

namespace Lab5_1
{
    internal class Mang
    {
        public static void Display()
        {
            // Khai báo mảng có 10 phần tử 
            int[] a = new int[10];

            int[] b = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Các phần tử của mảng: ");
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("{0}", b[i]);
            }

            // Tìm ra phần tử lớn nhất
            Console.WriteLine("Tìm ra phần tử lớn nhất: ");

            int max = b[0];
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i] < max)
                {
                    max = b[i];
                }
            }
            Console.WriteLine("Max: {0}", max);
        }

    }
}
