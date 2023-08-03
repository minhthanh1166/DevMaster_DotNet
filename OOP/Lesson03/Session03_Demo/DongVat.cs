using System;

namespace Session03_Demo
{
    class DongVat
    {
        protected string chan;
        protected string tay;
        protected string mieng;
        protected string duoi;

        protected static string namesd;


        public DongVat(string chan, string tay, string mieng, string duoi)
        {
            this.chan = chan;
            this.tay = tay;
            this.mieng = mieng;
            this.duoi = duoi;
        }
        public DongVat() { }

        protected void Display()
        {
            Console.WriteLine("Chan" + chan);
        }
    }

    class DongVatTrenCan : DongVat
    {
        public new void Display()
        {
            base.Display();
            Console.WriteLine("tay" + tay);
        }
    }

    class Meo : DongVatTrenCan
    {
        public new void Display()
        {
            base.Display();
            Console.WriteLine("mieng" + mieng);
        }
    }
}
