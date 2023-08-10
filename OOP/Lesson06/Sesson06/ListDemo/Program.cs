﻿using System;
using System.Collections.Generic;

namespace ListDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generic List");

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            Console.WriteLine("\nDanh sach");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }

            list.Sort((x, y) => { return y - x; });

            Console.WriteLine("\nDanh sach");
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }



            Console.ReadLine();
        }
    }
}
