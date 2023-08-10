using System;
using System.Collections;

namespace Sesson06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Demo arraylist collection");
            /// Khoi tao 
            ArrayList arr = new ArrayList();

            /// Properties
            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);

            Console.WriteLine("\n");

            //Method
            arr.Add("Devmaster");
            arr.Add(6);
            arr.Insert(1, true);

            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);

            string[] name = { "Chung", "Tring", "Van" };

            arr.AddRange(name);

            Console.WriteLine("Count: " + arr.Count);
            Console.WriteLine("Capacity: " + arr.Capacity);


            Console.WriteLine("\n");

            //Phuong thuc duyet colection
            // for, foreach, while, do..while
            Console.WriteLine("Danh sach cac phan tu");
            for (int i = 0; i < arr.Count; i++)
            {
                Console.WriteLine("\n" + arr[i]);
            }

            Console.WriteLine("Danh sach cac phan tu");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }

            // Method xoa (Remove, RemoveAt, RemoveRange, Clear)
            //arr.Remove("Devmaster");
            //Print(arr);
            //arr.RemoveAt(0);
            //Print(arr);
            //arr.RemoveRange(1, 2);
            //Print(arr);
            //arr.Clear();
            //Print(arr);

            // Sap xep

            arr = new ArrayList()
            {
                "Devmaster",
                "academy",
                "Chung",
                "van"
            };

            Print(arr);

            arr.Sort();
            Print(arr);

            arr.Sort();
            arr.Reverse();
            Print(arr);

            arr.Sort(new CaseInsensitiveComparer());
            Print(arr);


            // Tim kiem indexOf
            if (arr.IndexOf("Chung") > 0)
            {
                Console.WriteLine("\nTim thay " + arr.IndexOf("Chung"));
            }
            else
            {
                Console.WriteLine("\nKhong tim thay");
            }

            // Contain
            if (arr.Contains("van"))
            {
                Console.WriteLine("\nTim thay " + arr.Contains("van"));
            }
            else
            {
                Console.WriteLine("\nKhong tim thay");
            }

            Console.ReadLine();
        }

        static void Print(ArrayList arr)
        {
            Console.WriteLine("\nDanh sach cac phan tu");
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
