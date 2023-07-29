using System;

namespace Lab3_3
{
    public class Student
    {
        private int id;
        private string name;
        private byte age;

        // Tạo constructor không tham số
        public Student()
        {
            this.id = 0;
            this.name = "null";
            this.age = 0;
        }

        // Tạo constructor có tham số
        public Student(int id, string name, byte age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        // Tạo get set cho đối tuong student 
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public byte Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


        // Method Display 
        public void Display()
        {

            Console.WriteLine("Mã số: " + Id);
            Console.WriteLine("Tên sinh viên: " + Name);
            Console.WriteLine("Tuổi: " + Age);
        }
    }
}
