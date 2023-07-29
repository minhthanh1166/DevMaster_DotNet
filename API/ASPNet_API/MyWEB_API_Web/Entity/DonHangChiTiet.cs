using MyWEB_API_Web.Data;

namespace MyWEB_API_Web.Entity
{
    public class DonHangChiTiet
    {
        public Guid MaDonHang { get; set; }
        public Guid MaHangHoa { get; set; }
        public int SoLuong { get; set; }
        public double DonGia { get; set; }
        public byte GiamGia { get; set; }

        //Relationship
        public DonHang donHang { get; set; }
        public HangHoa hangHoa { get; set; }
    }
}
