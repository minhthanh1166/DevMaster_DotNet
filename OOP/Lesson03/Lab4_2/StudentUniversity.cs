using System;

namespace Lab4_2
{
    internal class StudentUniversity : StudentCollege
    {
        protected double Score4;

        public StudentUniversity(string Name, string Year, double Score1, double Score2, double Score3, double Score4) : base(Name, Year, Score1, Score2, Score3)
        {
            this.Score4 = Score4;
        }

        public override double Average()
        {
            return (Score1 + Score2 + Score3 + Score4) / 4;
        }

        public new void Display()
        {
            base.Display();
            Console.WriteLine("Score 4: {0:N}", Score4);
        }

    }
}
