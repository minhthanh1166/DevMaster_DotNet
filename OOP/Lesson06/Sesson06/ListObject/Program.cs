using System;
using System.Collections.Generic;

namespace ListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List Generic Collection");
            List<Student> list = new List<Student>()
            {
                  new Student()
                {
                    Id = 1,
                    Name = "Nguyen Van A",
                    Age = 22
                },
                 new Student()
                {
                    Id = 2,
                    Name = "Nguyen Van B",
                    Age = 23
                },
                  new Student()
                {
                    Id = 3,
                    Name = "Nguyen Van C",
                    Age = 24
                },
                   new Student()
                {
                    Id = 4,
                    Name = "Nguyen Van D",
                    Age = 25
                }
            };

            Show(list);


            // Sap xep 
            list.Sort((x, y) => { return y.Age - x.Age; });
            Show(list);

            list.Sort((x, y) => { return y.Age - x.Age; });
            Show(list);

            Console.ReadLine();
        }

        static void Show(List<Student> list)
        {

        }
    }
}
