using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class Queues
    {
        public static void MyQueues()
        {
            Queue queue = new Queue();
            queue.Enqueue("Apple");
            queue.Enqueue("Banana");
            queue.Enqueue("Cherry");

            Console.WriteLine("\nDanh sach cac phan tu Queue: ");
            RenderData(queue);

            // Xoa phan tu queue
            queue.Dequeue();
            Console.WriteLine("\nDanh sach phan tu dau tien bi xoa");
            RenderData(queue);
        }

        static void RenderData(Queue queue)
        {
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
