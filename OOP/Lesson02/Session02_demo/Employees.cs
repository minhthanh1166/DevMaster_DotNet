using System;

namespace Session02_demo
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        // Xây dựng hàm khởi tạo -> Phương thức đặc biệt
        public Employees(int Id, string Name, byte Age)
        {
            this.Id = Id;
            this.Name = Name;
            this.Age = Age;
        }

        public Employees()
        {
            Id = 0;
            Name = "Null";
            Age = 0;
        }

        // Method
        public void Display()
        {
            Console.WriteLine("\n Thông tin nhân viên");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }
    }
}
