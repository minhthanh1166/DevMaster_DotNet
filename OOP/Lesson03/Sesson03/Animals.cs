using System;

namespace Sesson03
{
    class Animals
    {
        public string name;
        public Animals(string name)
        {
            this.name = name;
        }

        public Animals() { }
    }

    class Canime : Animals
    {
        public Canime() : base() { }
        public Canime(string name) : base("Lion") // Gọi constructor lớp cơ sở
        {
            Console.WriteLine("Devmaster");

        }
    }
}
