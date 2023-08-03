using System;
using System.Text;

namespace Lab4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            // Tạo một nhân viên
            IPerson staff = new Staff();
            object data = "Bách khoa Aptech";

            // Gọi hành động
            staff.Insert(data);
            staff.Update(data);
            staff.Delete(data);
            staff.Display(data);

            // Tạo sinh viên
            IPerson student = new Student()
            {
                Id = 1,
                Name = "Bùi Minh Thành",
                Age = 21
            };

            // Hiển thị dữ liệu
            student.Display(student);

            Console.ReadLine();
        }
    }
}
