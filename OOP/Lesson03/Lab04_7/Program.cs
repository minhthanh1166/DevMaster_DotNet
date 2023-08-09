using System;

namespace Lab04_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVienBanHang nv = new NhanVienBanHang();
            nv.HienThi();
            CongNhan cn = new CongNhan();
            cn.HienThi();

            Console.ReadLine();
        }
    }
}
