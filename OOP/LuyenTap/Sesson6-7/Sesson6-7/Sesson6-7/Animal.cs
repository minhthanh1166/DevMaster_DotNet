using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson6_7
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public Animal() { }
        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, string description)
        {
            this.Name = name;
            this.Age = age;
            this.Description = description;
        }

        public void ViewInfo()
        {
            Console.WriteLine($"\nName: {this.Name} \nAge: {this.Age} \nDescription: {this.Description}");
        }

        public virtual void Speak()
        {

        }
    }
}
