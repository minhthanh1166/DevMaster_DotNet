using System;
using System.Text;

namespace Lab4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            CheckAccount checkAccount = new CheckAccount(50000);
            checkAccount.Display();
        }
    }
}
