using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Stacks
    {
        public static void MyStack()
        {
            Stack stack = new Stack();
           
            stack.Push("Apple");
            stack.Push("Banana");
            stack.Push("Cherry");

            Console.WriteLine("\nDanh sach ban dau Stack");
            RenderData(stack);


            // Luu y cau truc trong Stack khong the sua doi
            // Chi duoc them, xoa Stack.

            stack.Pop();
            Console.WriteLine("\nDanh sach xoa phan tu stack co ten la Banana");
            RenderData(stack);

        }

        static void RenderData(Stack stack)
        {
            foreach (var item in stack)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
