using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntity
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Age { get; set; }

        public Customer(int id , string name, string city, int age)
        {
            Id = id;
            Name = name;
            City = city;
            Age = age;
        }

        public override string ToString()
        {
            return $"\nId: {Id} \nName: {Name} City: {City} \nAge: {Age}";
        }
    }
}
