using System;

namespace Sesson01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Biến, Kiểu dữ liệu, toán tử, toán hạng, biểu thức, câu lệnh, khối lệnh
            int x, y = 100;
            float a, b;
            char ch = 'Y';
            string name = "Bùi Minh Thành";
            var company = "Devmaster Academy";
            bool Gender = true;

            // Gán giá trị
            x = 200;
            b = 123.12f;
            a = b * 2;


            // Xuất ra màn hình 
            Console.Write("Xin chào, " + name + "\n");
            Console.WriteLine("Company: " + company + "\n");

            Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            Console.ReadKey();
        }
    }
}
