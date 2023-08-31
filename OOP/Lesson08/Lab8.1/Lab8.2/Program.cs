using Lab8._2;
using System.Text;

// Khởi tạo customer
Console.OutputEncoding = Encoding.UTF8;

var customer = new Customer[]
{
    new Customer { Id = 1, Name = "Sam"},
    new Customer { Id = 2, Name = "Số"},
    new Customer { Id = 3, Name = "Thức"},
    new Customer { Id = 4, Name = "Mai"}
};

// Khởi tạo order 
var order = new Order[]
{
    new Order {Id = 1, Product = "Book"},
    new Order {Id = 2, Product = "Game"},
    new Order {Id = 3, Product = "Chuyện"},
    new Order {Id = 4, Product = "Tranh"}
};

var result = from c in customer join o in order on c.Id equals o.Id select new { c.Id, c.Name, o.Product };

foreach (var item in result)
{
    Console.WriteLine(item.Id + " | " + item.Name + " | " + item.Product);
}