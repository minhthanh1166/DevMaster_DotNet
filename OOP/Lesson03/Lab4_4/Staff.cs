using System;

namespace Lab4_4
{
    internal class Staff : IPerson
    {
        public void Delete(object obj)
        {
            Console.WriteLine("Đã xóa đối tượng: " + obj);
        }

        public void Display(object obj)
        {
            Console.WriteLine("Thông tin đối tương: " + obj);
        }

        public void Insert(object obj)
        {
            Console.WriteLine("Đã thêm đối tượng: " + obj);
        }

        public void Update(object obj)
        {
            Console.WriteLine("Đã cập nhật đối tượng: " + obj);
        }
    }
}
