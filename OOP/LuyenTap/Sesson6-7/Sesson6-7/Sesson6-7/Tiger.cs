using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson6_7
{
    internal class Tiger : Animal
    {
        public Tiger(string name) : base(name)
        {

        }
        public Tiger(string name, int age) : base(name, age)
        {

        }
        public Tiger(string name, int age, string description) : base(name, age, description)
        {

        }

        public override void Speak()
        {
            throw new NotImplementedException();
        }
    }
}
