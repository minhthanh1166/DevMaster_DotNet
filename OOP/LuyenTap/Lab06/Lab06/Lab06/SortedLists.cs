using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class SortedLists
    {
        public static void MySortedList()
        {
            SortedList list = new SortedList();
            list.Add("Banana", 3.29);
            list.Add("Cherry", 3.1);
            list.Add("Apple", 3.12);
            

            Console.WriteLine("\nIn gia tri cua key Apple");
            Console.WriteLine($"Gia tri cua apple: {list["Apple"]}");

            Console.WriteLine("\nIn tat ca cac cap Key-Value trong SortedList");
            foreach (DictionaryEntry entry in list) Console.WriteLine(entry.Key + " : " + entry.Value);

            Console.WriteLine("\nKiem tra phan tu gia tien 3.29 co ton tai khong?");
            if (list.ContainsValue(3.29))
            {
                Console.WriteLine("Co ton tai: " + list["Apple"]);
            }
            else
            {
                Console.WriteLine("Khong tim thay gia tien trong SortedList");
            }
        }
    }
}
