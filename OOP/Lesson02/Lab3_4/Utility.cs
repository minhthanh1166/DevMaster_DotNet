using System;

namespace Lab3_4
{
    public class Utility
    {
        // Không sử dụng ref 
        public void SwapFake(int a, int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }

        // Sử dụng ref cho tham số
        public void SwapReally(ref int a, ref int b)
        {
            int tg = a;
            a = b;
            b = tg;
        }

        // Sử dụng out cho tham số
        public void AreaCircle(double radius, out double area)
        {
            area = 2 * Math.PI * radius;
        }
    }
}
