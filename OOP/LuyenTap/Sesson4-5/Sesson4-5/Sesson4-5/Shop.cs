using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sesson4_5
{
    internal static class Shop
    {
        private static Product _product;

        private static ArrayList ProductList = new ArrayList();
        public static void AddProduct(Product product)
        {


            _product = new Product()
            {
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                rate = product.rate
            };

            ProductList.Add(_product);
        }
        public static void RemoveProduct()
        {
            Console.WriteLine("\n1. Delete all");
            Console.WriteLine("2. Delete name");
            Console.WriteLine("3. Exit");
            byte n = byte.Parse(Console.ReadLine());
            Product product = new Product();
            while (n <= 3)
            {
                switch (n)
                {
                    case 1:
                        {
                            ProductList.Clear();
                            Console.WriteLine("Delete All Successful!");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Enter name: ");
                            string name = Console.ReadLine();
                            foreach (Product prd in ProductList)
                            {
                               if(name != null)
                                {
                                    if(prd.Name.Equals(name))
                                    {
                                        ProductList.Remove(prd);
                                        foreach(Product prdItem in ProductList)
                                        {
                                            prdItem.ViewInfo();
                                            break;
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Error!");
                            break;
                        }
                }
                break;
            }
        }
        public static void IterateProductList()
        {
            foreach (Product product in ProductList)
            {
                product.ViewInfo();
                float sumPoint = 0f;
                foreach (int point in product.rate)
                {
                    sumPoint += point;

                }
                float avgPoint = sumPoint / product.rate.Length;
                Console.WriteLine("Rate: " + avgPoint);
            }
        }
        public static void SearchProduct(string name)
        {
            foreach (Product item in ProductList)
            {
                if (name != null)
                {
                    if (item.Name.Contains(name))
                        item.ViewInfo();
                }
               
            }
        }

        public static byte Menu()
        {
            Console.WriteLine("\n========== Sesson 4 - 5 ===========");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. Iterate product list");
            Console.WriteLine("4. Search product");
            Console.WriteLine("5. Exit");
            Console.Write("Please select: ");
            byte n = byte.Parse(Console.ReadLine());
            return n;
        }
    }
}
