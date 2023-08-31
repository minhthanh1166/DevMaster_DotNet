using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sesson6_7
{
    internal class Program
    {
        private static int Menu()
        {
            Console.WriteLine("\n1. Add cage");
            Console.WriteLine("2. Remove cage");
            Console.WriteLine("3. Add amimal");
            Console.WriteLine("4. Remove animal");
            Console.WriteLine("5. Interate animals");
            Console.WriteLine("6. Exit");
            Console.Write("Please select: ");
            byte n = byte.Parse(Console.ReadLine());
            return n;
        }
        static void Main(string[] args)
        {
            while (Menu() <= 5)
            {
                switch (Menu())
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            break;
                        }
                    case 4:
                        {
                            break;
                        }
                    case 5:
                        {
                            break;
                        }
                    default: 
                        {
                            if(Menu() == 6)
                            {
                                Console.WriteLine("Exit");
                            }
                            Console.WriteLine("Error. Exit!");
                            break;
                        }
                }
            }
            Console.ReadLine();
        }
    }
}
