using System;

namespace Lab4_4
{
    internal class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Age { get; set; }

        public void Delete(object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }

        public void Display(object obj)
        {
            Student student = obj as Student;
            Console.WriteLine("Id: " + student.Id);
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Age: " + student.Age);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Đã thêm đối tượng: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Đã cập nhật đối tượng: " + obj);
        }
    }
}
