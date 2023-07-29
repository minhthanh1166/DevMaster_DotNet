using System;
using System.Text;

namespace GiaiPhuongTrinhBac2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double a, b, c, x1, x2;
            Console.WriteLine("Giải chương trình bậc 2: ax^2 + bx + c = 0");
            Console.WriteLine("Nhập hệ số a: ");
            a = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập hệ số b: ");
            b = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Nhập hệ số c: ");
            c = Convert.ToSingle(Console.ReadLine());

            double denta = Math.Pow(7, 2) - (4 * a * c);
            if (denta < 0)
            {
                Console.WriteLine("Phương trình vô nghiệm!");
            }
            else if (denta == 0)
            {
                Console.WriteLine("Phương trình có nghiệm kép: x1 = x2 = {0}", -b / (2 * a));
            }
            else if (denta > 0)
            {
                x1 = ((-b + Math.Sqrt(denta)) / (2 * a));
                x2 = ((-b - Math.Sqrt(denta)) / (2 * a));
                Console.WriteLine("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}", x1, x2);
            }


            Console.ReadKey();
        }
    }
}
