// See https://aka.ms/new-console-template for more information
Console.WriteLine("Linq to object!");

string[] a = { "Vang ba senh", "Bui Minh Thanh", "Dam Quoc Dan", "Quang Nhut" };

/// Select
/// Form
/// Where
/// Group by
/// Having
/// Order by
/// 

IEnumerable<string> data = from dt in a select dt;
foreach (string s in data)
{
    Console.WriteLine(s);
}

Console.WriteLine("\n");
Console.WriteLine("In ra nhung nguoi co ky tu an");

data = from dt in a where dt.Contains("an") select dt;
foreach (string s in data)
{
    Console.WriteLine(s);
}