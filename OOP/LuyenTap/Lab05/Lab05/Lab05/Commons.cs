using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal static class Commons
    {
        internal static byte DisplayMenu()
        {
            Console.WriteLine("\n======== Chương trình quản lý công việc ========");
            Console.WriteLine("1. Thêm mới 1 nhân viên vào mảng nhân viên");
            Console.WriteLine("2. Hiển thị tất cả nhân viên trong mảng");
            Console.WriteLine("3. Sắp xếp nhân viên theo lương giảm dần");
            Console.WriteLine("4. Chọn râ những nân viên có lương cao nhất");
            Console.WriteLine("5. Tìm nhân viên có chữa chữ 'nam' ");
            Console.WriteLine("6. Thoát");
            Console.Write("Xin mời chọn: ");
            byte n = byte.Parse(Console.ReadLine());
            return n;
        }

        internal static void DisplayEmployee()
        {
            NhanVienBanHang nvbh = new NhanVienBanHang();
            CongNhan cn = new CongNhan();
            nvbh.HienThi();
            cn.HienThi();
        }
    }
}
