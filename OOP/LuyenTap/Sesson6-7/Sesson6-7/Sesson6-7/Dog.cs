using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson6_7
{
    internal class Dog : Animal
    {
        public Dog(string name) : base(name)
        {

        }
        public Dog(string name, int age) : base(name, age)
        {

        }
        public Dog(string name, int age, string description) : base(name, age, description)
        {

        }
    }
}
