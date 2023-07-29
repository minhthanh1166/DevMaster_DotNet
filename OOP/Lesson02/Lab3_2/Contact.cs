using System;

namespace Lab3_2
{
    public class Contact
    {
        private int Id;
        private string FirstName;
        private string LastName;
        private string Address;
        private string Phone;
        private string Email;

        // Tạo Constructor không tham số
        public Contact()
        {
            FirstName = "null";
            LastName = "null";
            Address = "null";
            Phone = "null";
            Email = "null";
        }

        // Tạo Constructor có tham số 
        public Contact(int Id, string FirstName, string LastName, string Phone, string Email)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
        }

        // Tạo get set
        public int id
        {
            get { return Id; }
            set { Id = value; }
        }

        public string fistName
        {
            get { return FirstName; }
            set { FirstName = value; }
        }

        public string lastName
        {
            get { return LastName; }
            set { LastName = value; }
        }

        public string address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string phone
        {
            get { return Phone; }
            set { Phone = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        // Method  Display 
        public void Display()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Mã số: " + id);
            Console.WriteLine("Họ, tên đệm: " + fistName);
            Console.WriteLine("Tên: " + lastName);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("Số điện thoại: " + phone);
            Console.WriteLine("Email: " + email);
        }
    }
}
