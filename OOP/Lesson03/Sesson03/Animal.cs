using System;

namespace Sesson03
{

    internal class Animal
    {
        //protected chỉ cho phép lớp kế thừa truy cập

        protected string Food;
        protected string Name;

        public void Eat()
        {
            Console.WriteLine("Động vật ăn một vài thứ");
            Console.WriteLine("Animal Eating ---");
        }

        public void DoSomeThing()
        {
            Console.WriteLine("Động vật làm một vài thứ");
        }

    }

    class Cat : Animal
    {
        public void Actions()
        {
            Eat();
            DoSomeThing();
        }

        public void Display()
        {
            Food = "Rau";
            Name = "Abc";
            Console.WriteLine(Food, Name);
        }
    }

    class Dog : Animal
    {
        public void Eat()
        {
            Console.WriteLine("Động vật ăn một vài thứ");
        }

        public void DoAction()
        {
            base.Eat();
        }
    }
}
