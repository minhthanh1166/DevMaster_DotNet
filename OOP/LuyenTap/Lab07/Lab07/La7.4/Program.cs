using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La7._4
{
    internal class InvalidInputNumber : Exception
    {
        public InvalidInputNumber() : base("Hay nhap mot so lon hon 0") { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.Write("Hay nhap mot so: ");
            // Nhap va tung ngoai le 
            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());
                if(intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }catch(InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }
            catch(FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if(intNum > 0)
                {
                    // In ra day so * 100
                    for(intCnt = 0; intCnt < 10; intCnt++)
                    {
                        Console.WriteLine(intNum * intNum);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
