using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Lab07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Supply.Manufacturer manufacturer = new Supply.Manufacturer();
            manufacturer.Name = "Coca cola";
            manufacturer.Phone = "0829936692";
            manufacturer.Email = "thanhbui1166@gmail.com";

            // In thong tin 
            Console.WriteLine($"\nThong tin: \nName: {manufacturer.Name} \nPhone: {manufacturer.Phone}, \nEmail: {manufacturer.Email}");

            // Goi ra doi tuong store item 
            StoreItem item = new StoreItem();
            item.ItemNo = 613508;
            item.ItemName = "Store Inventory";
            item.Price = 80.00M;

            // In thong tin store item 
            Console.WriteLine($"\nIn thon tin store: \nItemNO: {item.ItemNo} \nItemName: {item.ItemName} \nItemPrice: {item.Price}");

            Console.ReadLine();
        }
    }
}
