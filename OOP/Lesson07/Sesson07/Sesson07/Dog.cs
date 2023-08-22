using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    /// <summary>
    /// Exercize 3 
    /// </summary>
    internal class Dog : Animal
    {
        /// <summary>
        /// properties
        /// </summary>
        
        public Dog() :base()
        {

        }

        public Dog(string name) : base()
        {
            Name = name;
        }
        public Dog(string name, int age) : base(name, age)
        {
            Name = name;
            Age = age;
        }

        public Dog(string name, int age, string discription) : base(name, age, discription)
        {
            Name = name;
            Age = age;
            Discription = discription;
        }

        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.WriteLine("Gâu gâu gâu !!!");

        }

        public override void Speak()
        {
            base.ViewInfo();
        }
    }
}
