using System;

namespace Lab4_3
{
    internal class Rectangle : Shape
    {
        // Phương thức nhập liệu 
        public void InputData()
        {
            Console.WriteLine("Nhập chiều dài: ");
            Length = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập chiều rộng: ");
            Width = float.Parse(Console.ReadLine());
        }

        // Ghi đè phương thức tính diện tích
        public override float Area()
        {
            return Length * Width;
        }


        // Ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * Length * Width;
        }
    }
}
