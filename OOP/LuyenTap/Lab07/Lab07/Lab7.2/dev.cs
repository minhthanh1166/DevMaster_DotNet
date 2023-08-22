using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    internal class House
    {
        public string HouseNo { get; set; }
        public decimal Price { get; set; } = 0;
    }

    // Tao namespace con dai ly nam trong namespace kinh doanh 
    namespace Dealership
    {
        // Tao lop xe 
        public class Car
        {
            public string CarNo { get; set; }
            public decimal Price { get; set; } = 0;
        }
    }
}
