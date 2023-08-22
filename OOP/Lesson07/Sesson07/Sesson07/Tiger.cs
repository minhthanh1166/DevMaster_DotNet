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
    internal class Tiger : Animal
    {
        /// <summary>
        /// Constructer 
        /// </summary>

        public Tiger(): base(){ }
        public Tiger(string name) : base(name){ }
        public Tiger(string name, int age) : base(name, age){ }
        public Tiger(string name, int age, string discription) : base(name, age, discription) { }

        /// <summary>
        /// override 
        /// </summary>
        
        public override void ViewInfo()
        {
            base.ViewInfo();
            Console.WriteLine("Gừ gừ gừ !!!");
        }

        public override void Speak()
        {
            base.ViewInfo();
        }
    }
}
