using System;

namespace Lab03_1
{
    public class Car
    {
        public string make { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public string year { get; set; }


        // Tạo ra phương thức Start 
        public void Start()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Xe đang khởi động . . .");
        }

        public void Stop()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Color: " + color);
            Console.WriteLine("Year: " + year);
            Console.WriteLine("Xe đang dừng . . .");
        }
    }
}
