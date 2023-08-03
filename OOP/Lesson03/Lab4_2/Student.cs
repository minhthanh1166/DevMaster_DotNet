using System;

namespace Lab4_2
{
    internal abstract class Student
    {
        protected string Name;
        protected string Year;


        public Student(string Name, string Year)
        {
            this.Name = Name;
            this.Year = Year;
        }

        protected void Display()
        {
            Console.WriteLine("Name: {0}, Year: {1}", Name, Year);
        }

        public abstract double Average();
    }
}
