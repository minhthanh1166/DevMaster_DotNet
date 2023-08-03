using System;

namespace Sesson04_DeMo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.DoWork();
            employee.EnviromentWork();

            Console.WriteLine("\n");

            // Khởi tạo
            Document document = new Document();
            document.Read();
            document.Write("Dev");

            IStoreable doc = new Document();
            doc.Read();
            doc.Write("Devmaster");

            Console.WriteLine("\n");

            // Đa thừa kế
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.Cal1_Add(100, 200));
            Console.WriteLine(calculator.Cal2_Add(300, 200));
            Console.WriteLine(calculator.Div(3, 2));
            Console.WriteLine(calculator.Mul(3, 2));
            Console.WriteLine(calculator.Sub(2, 3));


            // Test - giao diện kế thừa lớp giao diện

            KhunNam khunNam = new KhunNam();
            khunNam.BuildMidel();
            khunNam.Buid();
            khunNam.Model();

            Console.ReadLine();
        }
    }
}
