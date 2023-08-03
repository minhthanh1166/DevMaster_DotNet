using System;

namespace Lab4_6
{
    internal class CheckAccount : Account
    {
        public double FeeTransfer = 2000;
        public CheckAccount(double initialize) : base(initialize)
        {
        }

        public CheckAccount(double Balance, double FeeTransfer) : base(Balance)
        {
            this.FeeTransfer = FeeTransfer;
        }

        protected override void Deposit(double money)
        {
            base.Deposit(money);
            Balance -= FeeTransfer;
            Console.WriteLine("Phí giao dịch: " + FeeTransfer);
        }

        protected override void WithDraw(double money)
        {

            base.WithDraw(money);
            Balance -= FeeTransfer;
            Console.WriteLine("Phí giao dịch: " + FeeTransfer);
        }

        protected override double GetBalance()
        {
            return Balance - FeeTransfer;
        }

        public void Display()
        {
            bool check = true;
            while (check)
            {
                byte x;
                Console.WriteLine("Tài khoản gốc: " + Balance);
                Console.WriteLine("1. Gửi tiền");
                Console.WriteLine("2. Rút tiền");
                Console.WriteLine("Nhấn số bất kì để thoát: ");
                try
                {
                    x = byte.Parse(Console.ReadLine());
                }
                catch
                {
                    x = 0;
                }

                switch (x)
                {
                    case 1:
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Nhập số tiền muốn gửi: ");
                            double money = double.Parse(Console.ReadLine());
                            Deposit(money);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("\n");
                            Console.WriteLine("Nhập số tiền muốn rút: ");
                            double moneyr = double.Parse(Console.ReadLine());
                            WithDraw(moneyr);
                        }
                        break;
                    default:
                        {
                            check = false;
                        }
                        break;
                }
            }
        }
    }
}
