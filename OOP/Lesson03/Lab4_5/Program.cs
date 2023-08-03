using System;

namespace Lab4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a car object
            Car car = new Car();
            Console.WriteLine("Calling car.Start();");
            car.Start();
            Console.WriteLine("Calling car.TurnLeft();");
            car.TurnLeft();
            Console.WriteLine("Calling car.TurnRight();");
            car.TurnRight();
            Console.WriteLine("Calling car.Accelerate();");
            car.Accelerate();
            Console.WriteLine("Calling car.Stop();");
            car.Stop();

            Console.ReadLine();
        }
    }
}
