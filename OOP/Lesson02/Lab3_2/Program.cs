using System;
using System.Text;

namespace Lab3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Contact contact = new Contact()
            {
                id = 1,
                fistName = "Bùi Minh",
                lastName = "Thành",
                address = "Thái Bình",
                phone = "0829936692",
                email = "buiminhthanh116@gmail.com"
            };

            contact.Display();

            contact.id = 2;
            contact.fistName = "Trịnh Văn";
            contact.lastName = "Chung";
            contact.address = "Hà Nội";
            contact.phone = "0966838383";
            contact.email = "chungtringj@gmail.com";
            contact.Display();

            Console.ReadKey();
        }
    }
}

