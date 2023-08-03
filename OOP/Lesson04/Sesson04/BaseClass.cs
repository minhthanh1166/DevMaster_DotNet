using System;

namespace Sesson04
{
    internal class BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Salary { get; set; }

        public BaseClass()
        {

        }

        public BaseClass(int id, string name, float salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        // Method (Ghi đè phương thức của lớp cha)
        public override string ToString()
        {
            return String.Format("Id: {0} \n Name: {1} \n Salary: {2}", Id, Name, Salary);
        }

        public virtual float CalculatorPay()
        {
            return Salary;
        }
    }
    /// <summary>
    /// Lớp con, lớp dẫn xuất kế thừa từ lớp cha
    /// </summary>
    class DriverClass : BaseClass
    {
        // properties 
        public float Bonus { get; set; }
        public DriverClass() : base() { }
        public DriverClass(int id, string name, float salary, float bonus) : base(id, name, salary)
        {
            Bonus = Bonus;
        }

        public override string ToString()
        {
            return base.ToString() + String.Format("\n Bonus: {0} \n Total: ", Bonus, CalculatorPay());
        }

        public override float CalculatorPay()
        {
            return base.CalculatorPay() + Bonus;
        }

        public float CalculatorPay(float thuong)
        {
            return Bonus * thuong;
        }
    }
}
