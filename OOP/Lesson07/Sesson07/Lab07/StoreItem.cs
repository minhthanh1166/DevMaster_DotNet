using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07
{
    namespace Store
    {
        public class StoreItem
        {
            public int ItemNo { get; set; }
            public string ItemName { get; set; }
            public StoreItem() { }
        }
    }

    namespace Supply
    {
        public class ManuFacturer
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
    }
}


