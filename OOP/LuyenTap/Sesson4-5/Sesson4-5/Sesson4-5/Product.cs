using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Sesson4_5
{
    internal class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        private double price;

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0 || value <= 100)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Price must be between 1 and 100");
                }
            }
        }

        public int[] rate { get; set; }
   

        public void ViewInfo()
        {
        
            Console.WriteLine($"\nName: {Name} \nDescription: {Description} \nPrice: {Price}");
        }

        public void InputInfo()
        {
            Console.Write("Enter name: ");
            this.Name = Console.ReadLine();
            Console.Write("Enter description: ");
            this.Description = Console.ReadLine();
            Console.Write("Enter price: ");
            this.Price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter rate: ");
            this.rate = new int[1];
            this.rate[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("-");
        }
    }
}
