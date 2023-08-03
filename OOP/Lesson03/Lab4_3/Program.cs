using System;
using System.Text;

namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Rectangle rectangle = new Rectangle();
            // Nhập liệu
            rectangle.InputData();
            Console.WriteLine("Diện tích hình chữ nhật là : {0:N}", rectangle.Area());
            Console.WriteLine("Chu vi hình chữ nhật là: {0:N}", rectangle.Circumference());

            Console.WriteLine("\n");

            // Khởi tạo hình tròn
            Cricle cricle = new Cricle();
            cricle.InputData();
            Console.WriteLine("Diện tích hình tròn: {0:N}", cricle.Area());
            Console.WriteLine("Chu vi hình tròn: {0:N}", cricle.Circumference());


            Console.ReadLine();
        }
    }
}
