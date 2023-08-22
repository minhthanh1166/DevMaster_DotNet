using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Tao doi tuong moi trong namespace Business
            // Ban co the using de tep viet ngan ngon hon 
            Business.House house = new Business.House();
            // Gan thong tin 
            house.HouseNo = "#000";
            house.Price = 100;

            // In thong tin 
            Console.WriteLine($"\nIn thong tin House: House No: {house.HouseNo} \nHouse Price: {house.Price}");

            // Goi doi tuong Car 
            Business.Dealership.Car car = new Business.Dealership.Car();
            car.CarNo = "F551dd";
            car.Price = 200;

            Console.WriteLine($"\nIn thong tin Car: Car No: {car.CarNo} \nCar Price: {car.Price}");


            Console.ReadLine();
        }
    }
}
