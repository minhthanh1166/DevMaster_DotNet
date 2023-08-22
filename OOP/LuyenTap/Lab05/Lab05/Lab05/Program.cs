using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NhanVien[] nv = new NhanVien[10];

            NhanVienBanHang nvbh1 = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn A",
                DiaChi = "Thái Nguyên",
                SoLuongBanDuoc = 12
            };
            NhanVienBanHang nvbh2 = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn B",
                DiaChi = "Thái Hậu",
                SoLuongBanDuoc = 13
            };
            NhanVienBanHang nvbh3 = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn C",
                DiaChi = "Thái Lan",
                SoLuongBanDuoc = 14
            };
            NhanVienBanHang nvbh4 = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn D",
                DiaChi = "Thái Chai",
                SoLuongBanDuoc = 15
            };
            NhanVienBanHang nvbh5 = new NhanVienBanHang
            {
                Ten = "Nguyễn Văn F",
                DiaChi = "Thái Lọ",
                SoLuongBanDuoc = 16
            };

            CongNhan congNhan1 = new CongNhan
            {
                Ten = "Nguyễn Văn 1",
                DiaChi = "An Ninh",
                SoLuongSanPham = 17
            };

            CongNhan congNhan2 = new CongNhan
            {
                Ten = "Nguyễn Văn 2",
                DiaChi = "An Mỹ",
                SoLuongSanPham = 18
            };

            CongNhan congNhan3 = new CongNhan
            {
                Ten = "Nguyễn Văn 3",
                DiaChi = "An Quý",
                SoLuongSanPham = 19
            };

            CongNhan congNhan4 = new CongNhan
            {
                Ten = "Nguyễn Văn 4",
                DiaChi = "An Vinh",
                SoLuongSanPham = 20
            };

            CongNhan congNhan5 = new CongNhan
            {
                Ten = "Nguyễn Văn 5",
                DiaChi = "An Lễ",
                SoLuongSanPham = 21
            };

            nv[0] = nvbh1;
            nv[1] = nvbh2;
            nv[2] = nvbh3;
            nv[3] = nvbh4;
            nv[4] = nvbh5;

            nv[5] = congNhan1;
            nv[6] = congNhan2;
            nv[7] = congNhan3;
            nv[8] = congNhan4;
            nv[9] = congNhan5;



            while (true)
            {
                switch (Commons.DisplayMenu())
                {
                    case 1:
                        {

                            break;
                        }
                    case 2:
                        {
                            foreach (NhanVien nvbhs in nv)
                            {
                                nvbhs.HienThi();
                            }
                            break;
                        }
                    case 3:
                        {
                            var sapXepTheoLuong = nv.OrderByDescending(x => x.TinhLuong());
                            foreach (NhanVien nvs in sapXepTheoLuong)
                            {
                                nvs.HienThi();
                            }
                            break;
                        }
                }
            }


           


            Console.ReadLine();
        }
    }
}
