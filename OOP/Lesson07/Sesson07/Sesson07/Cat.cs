using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    internal class Cat : Animal
    {
        public Cat() : base() { }
        public Cat(string name) : base(name) { }
        public Cat(string name, int age) : base(name, age) { }
        public Cat(string name, int age, string discription) : base(name, age, discription) { }

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.WriteLine("Meo meo meo !!!");
        }

        public override void Speak()
        {
            base.ViewInfo();
        }
    }
}
