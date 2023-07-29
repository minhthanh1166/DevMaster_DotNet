using System;
using System.Text;

namespace Session02_demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Đề mô lớp đối tượng");
            Category category = new Category(); // Hàm khởi tạo mặc định
            // Gọi thực hiện phương thức
            category.Display();

            category.Id = 100;
            category.Name = "Devmaster";

            // Sử dụng phương thức 
            category.Display();


            //==============================================
            // Sử dụng lớp đối tượng product 
            Product product = new Product();

            product.Id = 200;
            product.Name = "Laptop dell";
            product.Quantity = 20;
            product.Price = 100;

            Console.WriteLine("\n");
            Console.WriteLine("Id: {0} \n Name: {1} \n Quantity {2} \n Price {3}",
                product.Id, product.Name, product.Quantity, product.Price);


            //===============================================

            Console.WriteLine("\n");
            Console.WriteLine("======= Thực hiện thao tác với đối tượng lớp Student =======");
            Student student = new Student();
            student.Display();
            // Truy xuất đến các thành phần thuộc tính
            student = new Student()
            {
                Id = 100,
                Name = "Bùi Minh Thành",
                Mark1 = 9,
                Mark2 = 10,
                Mark3 = 9.5
            };
            student.Display();
            // Average 
            double avg = student.Average();
            Console.WriteLine("Điểm trung bình: {0:###,#.##}", avg);
            Console.WriteLine("Tông: " + student.Add(100, 200));

            //===============================================
            // Sử dụng lớp đối tượng Calculator 

            Console.WriteLine("\n");

            int sum = Calculator.Add(4, 5);
            int sub = Calculator.Sub(5, 4);
            Calculator calculator = new Calculator();
            int Mul = calculator.Mul(4, 5);

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Sub: " + sub);
            Console.WriteLine("Mul: " + Mul);

            // ======== Tham chiếu / Tham trị: ref, out 
            Number number = new Number();
            int num1 = 123, num2 = 456;
            Console.WriteLine("\n");
            Console.WriteLine("Trước swap(Tham trị) num1: {0}, num2: {1}", num1, num2);
            number.Swap(num1, num2);
            Console.WriteLine("Sau swap(Tham trị) num1: {0}, num2: {1}", num1, num2);

            Console.WriteLine("\n");

            Console.WriteLine("Trước swap(Tham chiếu) num1: {0}, num2: {1}", num1, num2);
            number.Swap(ref num1, ref num2);
            Console.WriteLine("Sau swap(Tham chiếu) num1: {0}, num2: {1}", num1, num2);

            Console.WriteLine("\n");
            // out
            double chuVi;
            number.Calc(out chuVi, 2);
            Console.WriteLine("Chu vi: " + chuVi);


            /// Sử dụng lớp đối tượng Employees 
            // Demo Constructor
            Employees employees = new Employees();
            employees.Display();
            employees = new Employees(100, "Trần Ngọc Nam", 20);
            employees.Display();
            employees = new Employees()
            {
                Id = 200,
                Name = "Chung Chung",
                Age = 44
            };
            employees.Display();

            Console.ReadKey();
        }
    }
}
