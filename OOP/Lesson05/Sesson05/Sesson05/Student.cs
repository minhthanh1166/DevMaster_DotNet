namespace Sesson05
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("\n {0}, {1}, {2}", Id, Name, Age);
        }
    }
}
