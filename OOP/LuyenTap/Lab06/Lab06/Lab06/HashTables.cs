using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lab06
{
    internal class HashTables
    {
        public static void myHashTable()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("Name", "Join");
            hashtable.Add("Age", 30);
            hashtable.Add("Country", "Usa");


            // In ra giá trị của key "Name"
            Console.WriteLine("\nTen: " + hashtable["Name"]);

            Console.WriteLine("In tat ca.");

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("\n" + entry.Key + " : " + entry.Value);
            }

            // Kiểm tra xem key City có tồn tại trong Hashtable không?
            if (hashtable.ContainsKey("City"))
            {
                Console.WriteLine("\nThanh pho: " + hashtable["City"]);
            }else
            {
                Console.WriteLine("\nKhong tim thay thong tin ve thanh pho");
            }
        }
    }
}
