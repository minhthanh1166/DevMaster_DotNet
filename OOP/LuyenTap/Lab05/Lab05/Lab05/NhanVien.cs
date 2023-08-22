using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal abstract class NhanVien
    {
        public string Ten { get; set; }
        public string DiaChi { get; set; }
        public NhanVien(string ten, string diachi)
        {
            this.Ten = ten;
            this.DiaChi = diachi;
        }
        public NhanVien()
        {
            
        }
        public abstract double TinhLuong();
        public abstract void HienThi();
    }
}
