namespace Session02_demo
{
    public class Employee
    {
        private string id;
        private string fullName;
        private int salary;

        // Khai báo các thuộc tính
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public Employee()
        {

        }
    }
}
