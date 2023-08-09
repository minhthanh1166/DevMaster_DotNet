using System;

namespace Sesson05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Class, Object 
             * 
             * OOP:
             * Ke thua: Inheristance
             * Da Hinh: Polymorphsm (Overloading, Overriding: Virtual/ Override)
             * Truu tuong hoa: abstraction (class abstact/method abstract; interface)
             * Dong goi: Enscapsolation (access modifier: public / private / protected / internal)
             * 
             */

            /// Mang va chi muc
            /// khai bao mang

            // 
            Console.WriteLine("Lam viec voi mang mot chieu");
            int[] a;
            int[] b = new int[10];
            int[] c = new int[] { 10, 20, 30, 40, 50 };
            int[] d = { 11, 44, 66, 33, 99 };
            string[] strName = new string[10];
            string[] strValue = { "Hung", "Dung", "Sang", "Trong" };

            // Truy cap den cac phan tu
            // Gan gia tri 
            //b[0] = 100;
            strName[0] = "Devmaster";

            // Lấy giá trị
            Console.WriteLine("Truy cập lấy giá trị: {0}, \n {1} \n", b[0], strName[0]);

            // Duyệt mảng: bằng vòng lặp

            Console.WriteLine("In các phần tử trong mảng c: ");
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }

            Console.WriteLine("\n");

            // Duyệt mảng và gán giá trị ngẫu nhiên cho mảng b
            // Gán giá trị ngẫu nhiên
            Random rnd = new Random();
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(10, 99);
            }

            // In giá tri
            foreach (var i in b)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine("\n");

            /// Sắp xếp
            /// Sử dụng lớp array
            /// Sắp xếp mảng b

            Array.Sort(b);
            Array.Reverse(b);
            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            // Sử dụng mảng với lớp đối tượng

            Student[] students = new Student[3];

            // Nhập giá trị cho các phần tử trong mảng
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Nhap sinh vien thu: " + (i + 1));
                students[i] = new Student();

                Console.Write("Id: ");
                students[i].Id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                students[i].Name = Console.ReadLine();

                Console.Write("Age: ");
                students[i].Age = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n In danh sach sinh vien: ");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n");

            // sắp xếp theo age
            Array.Sort(students, (x, y) => { return x.Age - y.Age; });
            Console.WriteLine(" \t In danh sach sinh vien sap xep theo tuoi tang dan");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("\n");

            Array.Sort(students, (x, y) => { return y.Age - x.Age; });
            Console.WriteLine(" \t In danh sach sinh vien sap xep theo tuoi giam dan");
            foreach (var item in students)
            {
                Console.WriteLine(item.ToString());
            }



            Console.ReadLine();
        }
    }
}
