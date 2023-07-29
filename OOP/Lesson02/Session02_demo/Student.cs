using System;

namespace Session02_demo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Mark1 { get; set; }
        public double Mark2 { get; set; }
        public double Mark3 { get; set; }

        // Xây dựng các phương thức
        public void Display()
        {
            Console.WriteLine("====== Thông tin sinh viên ======");
            Console.WriteLine("Id\t:" + Id);
            Console.WriteLine("Name\t:" + Name);
            Console.WriteLine("\tMart1:{0}\n\tMark2:{1}\n\tMart3:{2}", Mark1, Mark2, Mark3);
        }

        // Xây dựng phương thức không có tham số, có giá trị trả về 
        public double Average()
        {
            return (Mark1 + Mark2 + Mark3) / 3;
        }

        // Phương thức có tham số có giá trị trả về
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
