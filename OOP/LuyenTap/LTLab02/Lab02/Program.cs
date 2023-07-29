using System;
using System.Text;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Nhập thông tin sinh viên bao gồm (Id,Name, Birthday, Mark1, Mark2, Mark3)
             * in ra thông tin sinh viên bao gồm cả điểm trung bình của ba môn
             */

            Console.OutputEncoding = Encoding.UTF8;

            int id;
            string name;
            double mark1, mark2, mark3, average;
            DateTime birthday;

            Console.WriteLine("Chào mừng bạn đến với chương trình!");

            // Nhập dữ liệu từ bàn phím
            Console.WriteLine("Nhập mã số: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập họ và tên: ");
            name = Console.ReadLine();
            Console.WriteLine("Nhập ngày sinh: ");
            birthday = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn thứ nhất: ");
            mark1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn thứ hai: ");
            mark2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập điểm môn thứ ba: ");
            mark3 = Convert.ToDouble(Console.ReadLine());

            average = (mark1 + mark2 + mark3) / 3;

            Console.WriteLine("\n");

            Console.WriteLine("Hiển thị thông tin: \n");

            Console.WriteLine("Mã số: {0}", id);
            Console.WriteLine("Họ và tên: {0}", name);
            Console.WriteLine("Ngày sinh: {0}", birthday);
            Console.WriteLine("Điểm trung bình của bạn là: " +
                "Điểm 1: {0}, Điểm 2: {1}, Điểm 3: {2}, Kết quả: {3}",
                mark1, mark2, mark3, average);

            Console.ReadKey();
        }
    }
}
