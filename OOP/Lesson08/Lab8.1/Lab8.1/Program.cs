using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// Khởi tạo tập dữ liệu 
string[] data =
{
   "Tây", "Bắc", "đã", "trở", "thành", "vùng", "đất", "hứa",
    "của", "thi", "ca", "nghệ", "thuật"
};

IEnumerable<string> results1 = from m in data select m;
Console.WriteLine("Hiển thị kết quả");
foreach (string item in results1)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");


// Truy vấn theo điều kiện lấy từ "vung"
IEnumerable<string> result2 = from s in data where s.Contains("v") || s.Equals("vùng") select s;
Console.WriteLine("Hiển thị kết quả Truy vấn theo điều kiện lấy từ \"vung\"");
foreach (string item in result2)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

// Sắp xếp dữ liệu xuôi
IEnumerable<string> result3 = from k in data orderby k select k;
Console.WriteLine("Hiển thị kết quả sắp xếp");
foreach (string item in result3)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");

// Sắp xếp dữ liệu ngược
IEnumerable<string> result4 = from k in data orderby k select k;
Console.WriteLine("Hiển thị kết quả sắp xếp");
foreach (string item in result4)
{
    Console.Write(item + " ");
}
Console.WriteLine("\n");


// Lấy tập dữ liệu mới 
var result5 = from g in data
              select new
              {
                  Thuong = g.ToLower(),
                  Hoa = g.ToUpper()
              };
// Hiển thị kết quả
Console.WriteLine("Chu thuong va hoa");
foreach (var item in result5)
{
    Console.WriteLine(item.Thuong + ":" + item.Hoa);
}
Console.WriteLine("\n");


List<int> listAge = new List<int>()
{
    20, 30, 40, 50, 60, 70, 80, 90, 100
};

var resultAge = from num in listAge select num;
Console.WriteLine("Age");
string ageString = string.Join(", ", resultAge);
Console.WriteLine(ageString);
Console.WriteLine("\n");


string[] ArrayString = new string[] { "xử lý", "chuỗi trong", "c#" };
string strRs = string.Join(", ", ArrayString);
Console.WriteLine(strRs);
Console.WriteLine("\n");


resultAge = from num in listAge select num;
Console.WriteLine("Age string buff");
StringBuilder sb = new StringBuilder();
foreach (var item in resultAge)
{
    sb.Append(item);
    sb.Append(", ");
}
sb.Length -= 2; // Loại bỏ dấu phẩy và khoảng trắng cuối cùng
Console.WriteLine(sb.ToString());
Console.WriteLine();




