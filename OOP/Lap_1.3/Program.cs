using System;
using System.Text;

namespace Lap_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khai báo các biến 
            int id = 1;
            string name = "David George";
            byte age = 18;
            char gender = 'M';
            // Khai báo hằng số
            const float percent = 75.50f;

            // Hiển thị giá trị các biến và hằng số 
            Console.WriteLine("Student ID: {0}", id);
            Console.WriteLine("Student name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Percentage: {0}", percent);


            // 1.1 Viết in ra chương trình C#
            Console.WriteLine("\n");
            Console.WriteLine("       +++++                    +++++     +++++");
            Console.WriteLine("     ++++++++++                +++++     +++++");
            Console.WriteLine("   ++++++++++++++         +++++++++++++++++++++++");
            Console.WriteLine("  +++++      ++++        +++++++++++++++++++++++");
            Console.WriteLine("  ++++                  +++++++++++++++++++++++");
            Console.WriteLine("  ++++                      +++++     +++++");
            Console.WriteLine("  ++++                     +++++     +++++");
            Console.WriteLine("  ++++                +++++++++++++++++++++++");
            Console.WriteLine("  +++++      ++++    +++++++++++++++++++++++");
            Console.WriteLine("  +++++++++++++++   +++++++++++++++++++++++");
            Console.WriteLine("     ++++++++++         +++++     +++++");
            Console.WriteLine("       +++++           +++++     +++++");

            // Bài 1.2 Viết chương trình thực hiện các yêu cầu sau 
            string MaNV;
            string HoTenNV;
            string NgaySinh;
            string DiaChi;
            string DienThoai;
            string Email;

            MaNV = "NV01";
            HoTenNV = "Bùi Minh Thành";
            NgaySinh = "11/06/2001";
            DiaChi = "Thái Bình";
            DienThoai = "0829936692";
            Email = "buiminhthanh116@gmail.com";

            Console.WriteLine("\n");
            Console.WriteLine("Mã nhân viên: {0}", MaNV);
            Console.WriteLine("Họ và tên: {0}", HoTenNV);
            Console.WriteLine("Ngày sinh: {0}", NgaySinh);
            Console.WriteLine("Địa chỉ: {0}", DiaChi);
            Console.WriteLine("Điện thoại: {0}", DienThoai);
            Console.WriteLine("Email: {0}", Email);



            Console.ReadKey();
        }
    }
}
