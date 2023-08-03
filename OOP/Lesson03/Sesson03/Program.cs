using System;

namespace Sesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(NapChong.Add(10, 20));

            // Kế thừa 
            //Animal animal = new Animal();
            //animal.Eat();
            //animal.DoSomeThing();

            //Cat cat = new Cat();
            //cat.DoSomeThing();
            //cat.Actions();
            //cat.Eat();

            //Console.WriteLine("Test Protected");
            //// animal.Food = "Rau" // Lỗi không cho phép truy cập tù lớp ngoài



            //cat.Display();

            //Department department = new Department();
            //department.Display();


            // Test constructor
            Canime canime = new Canime();
            canime.name = "Animal";
            Console.WriteLine(canime.name);


            NhanVienSales nvs = new NhanVienSales()
            {
                Name = "NVA",
                basePay = 10000,
                salesBonus = 500
            };
            Console.WriteLine(nvs.CalculatePay());


            Console.ReadLine();
        }
    }
}
