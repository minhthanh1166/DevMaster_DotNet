namespace Sesson03
{
    public class NapChong
    {
        public static int Sum(int a)
        {
            int s = 0;
            for (int i = 1; i <= a; i++)
            {
                s += i;
            }
            return s;
        }

        public static int Sum(int a, int b)
        {
            int s = 0;
            for (int i = a; i <= b; i++)
            {
                s += i;
            }
            return s;
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static double Add(double x, double y)
        {
            return x + y;
        }

        public static float Add(float x, float y)
        {
            return x + y;
        }
    }
}
