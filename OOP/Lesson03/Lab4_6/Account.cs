using System;

namespace Lab4_6
{
    internal class Account
    {

        protected double Balance { get; set; }


        public Account(double initialize)
        {
            //  this.Balance = Balance;
            Balance = initialize;
        }

        protected virtual void Deposit(double money)
        {
            if (money > 0)
            {
                Balance += money;
                Console.WriteLine("Gửi tiền thành công!");
            }
        }

        protected virtual void WithDraw(double money)
        {

            if (money > 0)
            {
                Balance -= money;
                Console.WriteLine("Rút tiền thành công!");
            }
        }

        protected virtual double GetBalance()
        {
            return Balance;
        }
    }
}
