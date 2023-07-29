using System;
using System.Text;

namespace Lab02._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            double Money = 0;

            Console.WriteLine("Chào mừng bạn đến với phần mềm tính điện mất tiền :v");
            Console.Write("Nhập họ và tên khách hàng: ");
            string Name = Console.ReadLine();
            Console.Write("Nhập số điện sử dụng: ");
            int Numb = Convert.ToInt32(Console.ReadLine());

            if (Name == null && Numb <= 0)
            {
                Console.WriteLine("Vui lòng nhập dữ liệu đầu vào!");
            }

            if (Numb <= 30)
            {
                Money = 30;
            }
            else if (Numb > 30 && Numb <= 50)
            {
                for (int i = 0; i <= 50; i++)
                {
                    if (i <= 50)
                    {
                        Money = i * 1.2;
                    }
                }
            }
            else if (Numb > 50)
            {
                for (int i = 0; i <= Numb; i++)
                {
                    Money = i * 1.5;
                }
            }


            // In hóa đơn tiền điện
            Console.WriteLine("Họ và tên: {0}", Name);
            Console.WriteLine("Số điện dùng trong tháng này: {0}", Numb);
            Console.WriteLine("Số tiền phải trả là: {0}", Money);



            Console.ReadKey();
        }
    }
}
