using System;

namespace Session02_demo
{
    public class Category
    {
        // Member: Field / Properties
        // Field -- Khai báo các trường lưu trữ của đối tượng 
        private int id;
        private string name;


        // Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Method: Constructor / Destructor; normal method
        // Normal method -> khai báo phương thức
        public void Display()
        {
            Console.WriteLine("Categories: ");
            Console.WriteLine("Category Id: " + id);
            Console.WriteLine("Category Name: " + name);

        }
    }
}
