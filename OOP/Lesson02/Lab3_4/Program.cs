using System;
using System.Text;

namespace Lab3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Chương trình minh họa việc sử dụng từ khóa ref và out

            int a = 20, b = 30;
            double area;
            Utility utility = new Utility();

            Console.WriteLine("Trước khi hoán vị a = {0}, b = {1}", a, b);
            utility.SwapFake(a, b);

            Console.WriteLine("Sau khi hoán vị đang fake a = {0}, b = {1}", a, b);
            utility.SwapReally(ref a, ref b);

            Console.WriteLine("Sau khi hoán vị dang really a = {0}, b = {1}", a, b);

            utility.AreaCircle(100, out area);
            Console.WriteLine("Chu vi hình tròn bán kinh 100 là: {0}", area);


            Console.ReadKey();
        }
    }
}
