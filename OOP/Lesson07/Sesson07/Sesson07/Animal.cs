using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    /// <summary>
    /// Exercize 1 
    /// </summary>
    internal class Animal
    {
        // Properties
        public string Name { get; set; }
        public int Age { get; set; }
        public string Discription { get; set; }

        /// <summary>
        /// Exercize 2
        /// constructor
        /// </summary>

        public Animal()  { }
        public Animal(string name) 
        {
            Name = name;
        }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Animal(string name, int age, string discription)
        {
            Name = name;
            Age = age;
            Discription = discription;
        }

        // method 
        public virtual void ViewInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Discription: " + Discription);
        }

        public  virtual void Speak()
        {

        }
    }
}
