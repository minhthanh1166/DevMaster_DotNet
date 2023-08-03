using System;

namespace Lab4_2
{
    internal class StudentCollege : Student
    {
        protected double Score1;
        protected double Score2;
        protected double Score3;
        public StudentCollege(string Name, string Year, double Score1, double Score2, double Score3) : base(Name, Year)
        {
            this.Score1 = Score1;
            this.Score2 = Score2;
            this.Score3 = Score3;
        }

        public override double Average()
        {
            return (Score1 + Score2 + Score3) / 3;
        }

        // Hiển thị thông tin
        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score 1: {0:N}", Score1);
            Console.WriteLine("Score 2: {0:N}", Score2);
            Console.WriteLine("Score 3: {0:N}", Score3);
        }
    }
}
