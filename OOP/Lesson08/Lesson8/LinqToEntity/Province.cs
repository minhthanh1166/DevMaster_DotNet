using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToEntity
{
    internal class Province
    {
        public string City { get; set; }
        public int Capacity { get; set; }

        public Province(string city, int capacity)
        {
            City = city;
            Capacity = capacity;
        }
    }
}
