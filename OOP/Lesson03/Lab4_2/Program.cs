using System;
using System.Text;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khởi tạo sinh viên cao đẳng và in ra thông tin
            Console.WriteLine("Student of college: ");
            StudentCollege studentCollege = new StudentCollege("Hạnh", "11-06-2001", 9.5, 8, 7);
            studentCollege.Display();
            Console.WriteLine("Average of score: {0}", studentCollege.Average());
            Console.WriteLine("\n");


            // Khởi tạo sinh viên đại học và in ra thông tin
            Console.WriteLine("Student University: ");
            StudentUniversity studentUniversity = new StudentUniversity("Thanh", "15-05-2001", 6, 8, 7, 5);
            studentUniversity.Display();
            Console.WriteLine("Average of score: {0}", studentUniversity.Average());
            Console.WriteLine("\n");




            Console.ReadLine();
        }
    }
}
