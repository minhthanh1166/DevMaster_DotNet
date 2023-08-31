using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson6_7
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {

        }
        public Cat(string name, int age) : base(name, age)
        {

        }
        public Cat(string name, int age, string description) : base(name, age , description)
        {
            
        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
