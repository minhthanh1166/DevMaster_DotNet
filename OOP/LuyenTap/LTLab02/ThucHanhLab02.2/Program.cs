using System;
using System.Text;

namespace ThucHanhLab02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("========== Chương trình tính tiền điện ==========");
            string NameUser;
            int ElectricNumberLastMonth;
            int ElectricNumberMonth;
            double ElectricityFactor;
            double Money;

            try
            {
                // Input Data 
                Console.WriteLine("Nhập họ và tên khách hàng: ");
                NameUser = Console.ReadLine();
                Console.WriteLine("Nhập số điện công tơ tháng trước: ");
                ElectricNumberLastMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập số điện công tơ tháng này: ");
                ElectricNumberMonth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập hệ số tiền điện: ");
                ElectricityFactor = Convert.ToDouble(Console.ReadLine());

                if (NameUser == null && ElectricNumberLastMonth <= 0 && ElectricNumberMonth <= 0
                    && ElectricityFactor <= 0
                    && ElectricNumberMonth < ElectricNumberLastMonth)
                {
                    Console.WriteLine("Vui lòng nhập đúng và đủ!");
                }
                else
                {
                    Money = (ElectricNumberMonth - ElectricNumberLastMonth) * ElectricityFactor;


                    // Output Data
                    Console.WriteLine("\n");
                    Console.WriteLine("Thông tin khách hàng và tiền điện đã được tính");
                    Console.WriteLine("Họ và tên: {0}", NameUser);
                    Console.WriteLine("Tiền điện công tơ tháng trước: {0}", ElectricNumberLastMonth);
                    Console.WriteLine("Tiền điện công tơ tháng này: {0}", ElectricNumberMonth);
                    Console.WriteLine("Hệ số tiền điện: {0}", ElectricityFactor);
                    Console.WriteLine("Số tiền phải thanh toán: {0}", Money);
                }
            }
            catch
            {
                Console.WriteLine("Vui lòng nhập đúng và đủ!");
            }

            Console.ReadKey();
        }
    }
}
