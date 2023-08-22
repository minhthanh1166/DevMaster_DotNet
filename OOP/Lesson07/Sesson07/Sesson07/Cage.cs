using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sesson07
{
    /// <summary>
    /// Exercize 4
    /// </summary>
    internal class Cage
    {
        public int CageNumber { get; set; }

        ArrayList AnimalList = new ArrayList();

        public void AddAnimal(Animal obj)
        {
            AnimalList.Add(obj);
        }

        public void RemoveAnimal(string name)
        {
            foreach (Animal obj in AnimalList)
            {
                if (obj.Name == name)
                {
                    AnimalList.Remove(obj);
                    break;
                }
            }
        }
    }
}
