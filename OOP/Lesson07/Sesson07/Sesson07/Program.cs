using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Zoo zoo = new Zoo();
            bool check = true;
            do
            {
                // Tao menu 
                Console.WriteLine("\n====== Menu ======");
                Console.WriteLine("1. Add Cage");
                Console.WriteLine("2. Remove Cage");
                Console.WriteLine("3. Add Animal");
                Console.WriteLine("4. Remove Animal");
                Console.WriteLine("5. Iterator Animal");
                Console.WriteLine("6. Exit");
                Console.Write("Enter number");
                byte n = byte.Parse(Console.ReadLine());

            
                switch (n)
                {
                    case 1:
                        {
                            Console.WriteLine("Nhập chuồng số: ");
                            Cage cage = new Cage();
                            cage.CageNumber = int.Parse(Console.ReadLine());
                            zoo.Add(cage);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Nhập chuồng cần xóa: ");
                            byte s = byte.Parse(Console.ReadLine());
                            zoo.Remove(s);
                            break;
                        }
                    case 3:
                        {
                            // Nhập thông tin Animal
                            Console.Write("Animal Name: ");
                            string name = Console.ReadLine();
                            Console.WriteLine("Animal Age: ");
                            int age = int.Parse(Console.ReadLine());
                            Console.WriteLine("Animal Discription: ");
                            string discription = Console.ReadLine();

                            Animal animal = new Animal(name,age, discription);
                            animal.ViewInfo();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Animal Name Remove: ");
                            string name = Console.ReadLine();
                            Cage cage = new Cage();
                            cage.RemoveAnimal(name);
                            break;
                        }

                    case 5:
                        {
                            Console.WriteLine("Danh sách Animal: ");

                            break;
                        }
                    case 6:
                        {
                            check = false;
                            break;
                        }
                    default: 
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
            }while (check);
        }
    }
}
