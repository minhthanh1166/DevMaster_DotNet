using System;

namespace SoNguyenTo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======= Chương trình số nguyên tố =======");

            bool check_i;
            // Duyệt từ 2 đến 100
            for (int i = 2; i <= 100; i++)
            {
                check_i = true; // Giả sử i là số nguyên tố
                for (int j = 2; j <= i / 2; j++) // Duyệt từ 2-j/2
                {
                    if (i % j == 0) // Nếu i chia hết cho j thì
                    {
                        check_i = false; // kết luận không là số nguyên tố 
                        break;
                    }
                }
                if (check_i)
                {
                    Console.Write("{0}, ", i);
                }
            }

            Console.ReadKey();
        }
    }
}
