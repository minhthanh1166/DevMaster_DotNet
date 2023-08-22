using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class CongNhan : NhanVien
    {
        public int SoLuongSanPham { get; set; }
        public CongNhan(string ten, string diachi, int soLuongSanPham) : base(ten, diachi)
        {
            SoLuongSanPham = soLuongSanPham;
        }
        public CongNhan() :base()
        {

        }

        public override double TinhLuong()
        {
            NhanVienBanHang objNVBH = new NhanVienBanHang();
            return SoLuongSanPham + (objNVBH.TinhLuong() * 2);
        }

        public override void HienThi()
        {
            Console.WriteLine("\nTên công nhân: {0}, Địa chỉ: {1}, Số lượng sản phẩm: {2} Cái, Lương {3} vnđ.", Ten, DiaChi, SoLuongSanPham, TinhLuong());
        }
    }
}
