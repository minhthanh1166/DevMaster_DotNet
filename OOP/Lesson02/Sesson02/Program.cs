using System;

namespace Sesson02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Review = I/O - Control Flow");
            int n;
            Console.Write("Nhập n = ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                for (int j = n - i; j < n; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("*");
            }

            Console.ReadKey();
        }
    }
}
