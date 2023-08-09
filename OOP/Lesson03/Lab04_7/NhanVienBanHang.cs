using System;

namespace Lab04_7
{
    internal class NhanVienBanHang : NhanVien
    {
        private int SoLuongBanDuoc = 30;

        public NhanVienBanHang()
        {
            Ten = "Bùi Minh Thành";
            DiaChi = "26 Ngõ 193/64";
        }

        public override void HienThi()
        {
            Console.WriteLine(TinhLuong() + " " + Ten + " " + DiaChi);
        }

        public override double TinhLuong()
        {
            return SoLuongBanDuoc * 20000;
        }
    }
}
