using System;

namespace Lab04_7
{
    internal class CongNhan : NhanVien
    {
        public int SoLuongSanPham = 10000;

        public CongNhan()
        {
            Ten = "Nguyễn Duy";
            DiaChi = "192 Ngõ 165/25";
        }

        public override void HienThi()
        {
            Console.WriteLine(TinhLuong() + " " + Ten + " " + DiaChi);
        }

        public override double TinhLuong()
        {
            var nv = new NhanVienBanHang();

            return nv.TinhLuong() * SoLuongSanPham;
        }
    }
}
