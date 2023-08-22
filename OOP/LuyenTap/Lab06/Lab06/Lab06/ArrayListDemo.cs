using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class ArrayListDemo
    {
        // Hàm in các phần tử trong ArrayList
        static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void ArrayListDemos() {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("Apple");
            arrayList.Add("Banana");
            arrayList.Add("Cherry");

            Console.WriteLine("\nDanh sach ban dau: ");
            PrintArrayList(arrayList);

            arrayList[1] = "Ok luon";

            Console.WriteLine("\nSua phan tu tai vi tri index = 1");
            Console.WriteLine("Danh sach sau khi sua: ");
            PrintArrayList(arrayList);

            // Xoa phan tu Apple ra khoi danh sach 
            arrayList.Remove("Apple");

            Console.WriteLine("\nDanh sach sau khi xpa phan tu apple: ");
            PrintArrayList(arrayList);
        }
    }
}
