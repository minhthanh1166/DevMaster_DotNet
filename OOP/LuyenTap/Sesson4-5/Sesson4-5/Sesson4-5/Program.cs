using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            bool check = true;
            while (check)
            {
                switch (Shop.Menu())
                {
                    case 1:
                        {
                            Console.Write("Number of products you want to import: ");
                            int n = int.Parse(Console.ReadLine());
                            for (int i = 0; i < n; i++)
                            {
                                product.InputInfo();
                                Shop.AddProduct(product);
                            }
                          
                            break;
                        }
                    case 2:
                        {
                            Shop.RemoveProduct();
                            break;
                        }
                    case 3:
                        {
                            Shop.IterateProductList();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter name: ");
                            string name  = Console.ReadLine();
                            Shop.SearchProduct(name);
                            break;
                        }
                    default:
                        {
                            check = false;
                            Console.WriteLine("Error");
                            break;
                        }
                }
                Console.ReadLine();
            }
        }
    }
}
