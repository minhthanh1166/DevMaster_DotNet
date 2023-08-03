using System;

namespace Lab4_3
{
    internal class Cricle : Shape
    {
        // Phương thức nhập liệu
        public void InputData()
        {
            Console.WriteLine("Nhập bán kính: ");
            Radius = float.Parse(Console.ReadLine());
        }


        // Ghi đè phương thức tính diện tích
        public override float Area()
        {
            return 3.14f * Radius * Radius;
        }

        // Ghi đè phương thức tính chu vi
        public override float Circumference()
        {
            return 2 * 3.14f * Radius;
        }
    }
}
