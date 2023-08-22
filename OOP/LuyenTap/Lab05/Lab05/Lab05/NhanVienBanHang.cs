using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class NhanVienBanHang : NhanVien
    {
        public int SoLuongBanDuoc { get; set; }

        public NhanVienBanHang(string ten, string diachi, int soLuongBanDuoc) : base(ten, diachi)
        {
            this.SoLuongBanDuoc = soLuongBanDuoc;
        }

        public NhanVienBanHang():base() { }

        public override double TinhLuong()
        {
            return SoLuongBanDuoc * 10000;
        }

        public override void HienThi()
        {
            Console.WriteLine("\nTên nhân viên: {0}, Địa chỉ: {1}, Số lượng bán được: {2} Cái, Lương {3} vnđ.", Ten, DiaChi, SoLuongBanDuoc, TinhLuong());
        }
    }
}
