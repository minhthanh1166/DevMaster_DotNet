using System;

namespace Sesson03
{
    class Employee
    {
        int id = 10;
        string name = "Tran Thu Ha";
        byte age = 20;

        protected void Display()
        {
            Console.WriteLine("Emp Id: " + id);
            Console.WriteLine("Emp Name: " + name);
            Console.WriteLine("Age: " + age);
        }
    }

    class Department : Employee
    {
        int depid = 10;
        string depname = "Devmaster";

        // đây là phiên ban mới của phương thức Display ở lớp cha

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Dep Id: " + depid);
            Console.WriteLine("Dep Name: " + depname);
        }
    }
}
