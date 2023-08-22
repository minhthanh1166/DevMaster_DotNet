using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab07.Store;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply.ManuFacturer dealer = new Supply.ManuFacturer();
            // Gán giá trị
            dealer.Name = "Test";
            dealer.Email = "Test@gmail.com";
            dealer.Phone = "1234567890";
            // In thông tin 
            Console.WriteLine("Dealer information ");
            Console.WriteLine("\nName: {0}, \nEmail: {1}, \nPhone: {2}", dealer.Name, dealer.Email, dealer.Phone);


            // Tạo mới sản phẩm nằm trong namespace store


            Console.ReadLine();
        }
    }
}
