namespace Sesson04_DeMo
{
    internal class Calculator : ICalculator, ICalculator2
    {
        int ICalculator.Add(int a, int b)
        {
            return a + b;
        }

        int ICalculator2.Add(int a, int b)
        {
            return a + b;
        }

        public int Div(int a, int b)
        {
            if (b > 0)
            {
                return a / b;
            }
            return 0;
        }

        public int Mul(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a + b;
        }

        public int Cal1_Add(int a, int b)
        {
            ICalculator calc = this;
            return calc.Add(a, b);
        }

        public int Cal2_Add(int a, int b)
        {
            ICalculator2 calc = this;
            return calc.Add(a, b);
        }
    }
}
