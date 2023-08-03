using System;

namespace Sesson03
{
    internal abstract class NhanVien : IMatiAnimal
    {
        public string Name { get; set; }
        public float basePay { get; set; }

        // Constructor 
        public NhanVien() { }
        public NhanVien(string name, float basePay)
        {
            Name = name;
            this.basePay = basePay;
        }

        // Phương thức cho phép ghi đè ở lớp kế thừa
        public virtual float CalculatePay()
        {
            return basePay;
        }
        public abstract void Eat();
        public abstract int Sum();
    }

    /// Lớp con 
    /// Ghi đè phương thức của lớp cha 
    class NhanVienSales : NhanVien
    {
        public float salesBonus { get; set; }
        // Constructor
        public NhanVienSales() : base() { }
        public NhanVienSales(string name, string basePay, float salesBonus) : base()
        {
            this.salesBonus = salesBonus;
        }

        public override float CalculatePay()
        {
            return basePay + salesBonus;
        }


        public override void Eat()
        {
            Console.WriteLine();
            throw new NotImplementedException();
        }

        public override int Sum()
        {
            throw new NotImplementedException();
        }
    }
}
