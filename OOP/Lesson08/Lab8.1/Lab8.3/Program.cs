using Lab8._3;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 22, 33, 444, 555, 77, 99 };
string[] words =
{
     "Tây", "Bắc", "đã", "trở", "thành", "vùng", "đất", "hứa",
    "của", "thi", "ca", "nghệ", "thuật"
};

List<Film> films = new List<Film>()
{
    new Film {FilmId = 1, FilmName = "Điệp viên 007", Price = 12000},
    new Film {FilmId = 2, FilmName = "Tam quốc diễn nghia", Price = 5000},
    new Film {FilmId = 3, FilmName = "Trò chơi con mực", Price = 53000},
    new Film {FilmId = 4, FilmName = "Siêu nhân gao", Price = 26000},
    new Film {FilmId = 5, FilmName = "Cá mập bạo chúa", Price = 123000},
    new Film {FilmId = 6, FilmName = "Bàn tay thần chết", Price = 14000},
};

// Lọc số chẵn 
IEnumerable<int> result1 = numbers.Where(n => n % 2 == 0);
Console.WriteLine("Lọc số chẵn ");
foreach (int n in result1)
{
    Console.Write(n + " ");
}

Console.WriteLine("\n");

// Lọc các từ có độ dài > 4 
IEnumerable<string> result2 = words.Where(w => w.Length > 4);
Console.WriteLine("Lọc các từ có độ dài > 4 ");
foreach (string word in result2)
{
    Console.Write(word + " ");
}
Console.WriteLine("\n");

// Lọc các từ có tên bắt đầu là chữ T
IEnumerable<string> result3 = words.Where(w => w.StartsWith("t"));
Console.WriteLine("Lọc các từ có tên bắt đầu là chữ t");
foreach (string word in result3)
{
    Console.Write(word + " ");
}
Console.WriteLine("\n");

// Lọc các số duy nhất trong tập các số
var uniqueNumber = numbers.Distinct();
Show<int>(uniqueNumber, "Lọc các số duy nhất trong tập các số");


Console.WriteLine("\n");





// Định nghĩa phương thức generic để khởi tạo dữ liệu 
static void Show<T>(IEnumerable<T> data, string message)
{
    Console.WriteLine(message);
    foreach (T item in data)
    {
        Console.Write(item + " ");
    }
}


