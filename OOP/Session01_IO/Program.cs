using System;

namespace Session01_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "39";
            string b = "21";
            Console.WriteLine(a + b);

            int x = Convert.ToInt32(a);
            int y = Convert.ToInt32(b);

            Console.WriteLine(x + y);

            x = int.Parse(a);
            y = int.Parse(b);
            Console.WriteLine(x + y);

            // Nhập 
            Console.WriteLine("Nhập x = ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhập y = ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("Kết quả: {0}", x + y);

            double m = 123.12;
            Console.WriteLine(m);

            x = Convert.ToInt32(m);
            Console.WriteLine(x);
            m = y;
            Console.WriteLine(m);

            Console.ReadKey();
        }
    }
}
