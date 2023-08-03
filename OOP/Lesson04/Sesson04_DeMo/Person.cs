using System;

namespace Sesson04_DeMo
{
    /// <summary>
    /// Tạo lớp trừu tượng (Abstraction)
    /// </summary>
    internal abstract class Person
    {
        public void Speak()
        {
            Console.WriteLine("Mọi người đều nói tiếng việt");
        }

        // abstract method
        public abstract void DoWork();
        public abstract void EnviromentWork();
    }

    class Employee : Person
    {
        public override void DoWork()
        {
            Console.WriteLine("Làm việc rất vất vả");
        }

        public override void EnviromentWork()
        {
            Console.WriteLine("Làm việc không vất vả");
        }
    }
}
