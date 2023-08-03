using System;

namespace Lab4_5
{
    internal class Car : IMovable
    {
        private bool started = false;

        public bool Started
        {
            get
            {
                return started;
            }
        }

        public void Accelerate()
        {
            Console.WriteLine("Car Accelerateting");
        }

        public void Brake()
        {
            Console.WriteLine("Car Braking");
        }

        public void Start()
        {
            Console.WriteLine("Car started");
            started = true;
        }

        public void Stop()
        {
            Console.WriteLine("Car stoped");
            started = true;
        }

        public void TurnLeft()
        {
            Console.WriteLine("Car turning left");
        }

        public void TurnRight()
        {
            Console.WriteLine("Car turning right");
        }
    }
}
