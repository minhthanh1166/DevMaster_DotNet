using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    /// <summary>
    /// Exercise 5;
    /// </summary>
    internal class Zoo
    {
        ArrayList ZooLists = new ArrayList();

        public void Add(Cage obj)
        {
            ZooLists.Add(obj);
        }

        public void Remove(int id)
        {
            foreach (Cage obj in ZooLists)
            {
                if(obj.CageNumber == id)
                {
                    ZooLists.Remove(obj);
                    break;
                }
            }
        }
    }
}
