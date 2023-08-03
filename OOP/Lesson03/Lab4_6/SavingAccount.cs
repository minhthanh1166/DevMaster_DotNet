namespace Lab4_6
{
    internal class SavingAccount : Account
    {
        public double rate { get; set; }
        public SavingAccount(double initialize, double rate) : base(initialize)
        {
            this.rate = rate;
        }

        public double GetInterest()
        {
            return rate;
        }
    }
}
