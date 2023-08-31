

using LinqToEntity;

List<Customer> customers = new List<Customer>()
{
    new Customer(1, "Dung", "Ha Noi", 20),
    new Customer(2, "Sang", "Ha Noi", 21),
    new Customer(3, "Nung", "Ha Noi", 22),
    new Customer(4, "Yung", "Ha Noi", 23),
    new Customer(5, "Fung", "Ha Noi", 24),
};

List<Province> provinces = new List<Province>()
{
    new Province("Ha Noi", 10000),
    new Province("Ha Noi", 10000),
    new Province("Ha Noi", 10000),
    new Province("Ha Noi", 10000),
};

/// Linq :
/// Lấy tất cả khách hàng
var listCust = from customer in customers select customer;

// Duyet va in 

foreach (var item in listCust)
{
    Console.WriteLine(item.ToString());
}

/// Loc tất cả khách hàng từ 20 đến 30

//listCusts = from customer in where customer.;

//// Duyet va in 

//foreach (var item in listCus)
//{
//    Console.WriteLine(item.ToString());
//}

// kết hợp 2 đối tượng dữ liệu bằng join 


listCust = from c in customers join p in 
           provinces on c.City equals p.City 
           select c;

// Duyet va in 

foreach (var item in listCust)
{
    Console.WriteLine(item.ToString());
}
//


var dataJoin = from c in customers
               join p in
               provinces on c.City equals p.City
               select new
               {
                   Id = c.Id,
                   Name = c.Name,
                   City = c.City,
                   Age = c.Age,
                   Capacity = p.Capacity
               };

// Duyet va in 

foreach (var item in dataJoin)
{
    Console.WriteLine(item.Id);
    Console.WriteLine(item.Name);
    Console.WriteLine(item.City);
    Console.WriteLine(item.Age);
    Console.WriteLine(item.Capacity);
}


// Lấy 2 khách hàng đầu tiên 
var cust = customers.Take(2);
Console.WriteLine("=========== Lấy 2 khách hàng đầu tiên");
foreach (var item in cust)
{
    Console.WriteLine(item.ToString());
}

// Bỏ qua phần tử đầu tiên, lấy tất cả các phần tử còn lại 
cust = customers.Skip(1).Take(2);
Console.WriteLine("=========== Bỏ qua các phần tử đầu tiên, lấy tất cả các phần tử còn lại");
foreach (var item in cust)
{
    Console.WriteLine(item.ToString());
}
// Sắp xép khách hàng theo tuổi tăng dần 

Console.WriteLine("Sắp xếp theo tăng dần");
cust = customers.OrderBy(x => x.Age);
foreach (var item in cust)
{
    Console.WriteLine(item.ToString());
}

Console.WriteLine("Sắp xếp theo giảm dần");
cust = customers.OrderByDescending(x => x.Age);
foreach (var item in cust)
{
    Console.WriteLine(item.ToString());
}

// Lọc ra những khách hàng có tên chứa kí tự a 
cust = customers.Where(x => x.Name.Contains("a")).ToList();
Console.WriteLine("Lọc ra những khách hàng có tên chứa kí tự a ");
foreach (var item in cust)
{
    Console.WriteLine(item.ToString());
}