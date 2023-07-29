using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo đối tượng
            StudentModel studentModel = new StudentModel();
            // Gọi phương thức lấy tất cả sinh viên 
            List<Student> ListStudents = studentModel.GetListStudent();
            // Hiển thị 
            foreach (var item in ListStudents)
            {
                item.Display();
            }

            // Gọi phương thức lấy theo id
            Console.WriteLine("\n" + "Lấy sinh viên theo id");
            studentModel.GetStudentById(2).Display();

            Console.WriteLine("\n" + "Lấy sinh viên từ độ tuổi 22-50");
            List<Student> listAge = studentModel.GetStudentByAge(22, 50);
            foreach (var item in listAge)
            {
                item.Display();
            }

            Console.ReadKey();
        }
    }
}
