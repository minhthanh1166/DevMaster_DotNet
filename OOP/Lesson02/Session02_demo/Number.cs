namespace Session02_demo
{
    public class Number
    {
        // Method: Tham trị 
        public void Swap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Method: Tham chiếu
        public void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Method: out
        public void Calc(out double area, double radius)
        {
            area = radius * radius * 3.14f;
        }
    }
}
