using System;

namespace Mang2Chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Mang 2 chieu");
            //// Khai bao mang 2 chieu co 3 dong va 4 cot tong co 12 phan tu
            //int[,] arr = new int[3, 4];
            //// Sinh ngau nhien gia tri cho cac phan tu trong mang
            //Random rnd = new Random();
            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = rnd.Next(10, 99);
            //    }
            //}
            //Console.WriteLine("\n In mang 2 chieu");

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write("\t {0}", arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            // Khai báo mảng đa chiều để lưu bảng điểm
            int[,] studentScores = new int[15, 15];
            Random random = new Random();
            for (int i = 0; i < studentScores.GetLength(0); i++)
            {
                for (int j = 0; j < studentScores.GetLength(1); j++)
                {
                    studentScores[i, j] = random.Next(10, 99);
                }
            }

            // Hiển thị
            Console.WriteLine("Hiển thị điểm sinh viên");
            for (int i = 0; i < studentScores.GetLength(0); i++)
            {
                for (int j = 0; j < studentScores.GetLength(1); j++)
                {
                    Console.Write("\t {0}", studentScores[i, j]);
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
