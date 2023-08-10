using System;
using System.Collections;

namespace ArrayListObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Su dung arrayList de luu tru so luong sinh vien 
            ArrayList list = new ArrayList()
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

            // Add
            list.Add(new Student()
            {
                Id = 5,
                Name = "Nguyen Van E",
                Age = 26
            });
            Show(list);

            // Tim kiem, sap sep, xoa
            // Tim kiem in ra danh sach co tuoi lon hon 20
            bool notfound = false;
            foreach (Student item in list)
            {
                if (item.Age > 24)
                {
                    notfound = true;
                    Console.WriteLine("\nTim kiem");
                    Console.WriteLine("--- {0}, {1}, {2}", item.Id, item.Name, item.Age);
                }
            }
            if (notfound == false)
            {
                Console.WriteLine("\nTim kiem");
                Console.WriteLine("Khong tim thay");
            }


            Student st = new Student();
            // Sap xep
            Console.WriteLine("\nTang dan");
            list.Sort(new SortAgeASC());
            Show(list);

            Console.WriteLine("\nGiam dan");
            list.Sort(new SortAgeDESC());
            Show(list);
            Console.ReadLine();
        }

        static void Show(ArrayList arr)
        {
            Console.WriteLine("\nDanh sach sinh vien");
            foreach (Student item in arr)
            {
                Console.WriteLine("--- {0}, {1}, {2}", item.Id, item.Name, item.Age);
            }
        }


    }
    class SortAgeASC : IComparer
    {
        public int Compare(Object x, Object y)
        {
            return (x as Student).Age - (y as Student).Age;
        }
    }

    class SortAgeDESC : IComparer
    {
        public int Compare(Object x, Object y)
        {
            return (y as Student).Age - (x as Student).Age;
        }
    }
}
