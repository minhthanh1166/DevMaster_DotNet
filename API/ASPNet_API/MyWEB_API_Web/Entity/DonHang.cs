using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWEB_API_Web.Entity
{
    public enum TinhTrangDonDatHang
    {
        New = 0, Payment = 1, Complate = 2, Cancel = -1
    }


    [Table("Don_Hang")]
    public class DonHang
    {
        [Key]
        public Guid MaDonHang { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime? NgayGiao { get; set; }
        public TinhTrangDonDatHang TinhTrangDH { get; set; }
        public string NguoiNhanHang { get; set; }
        [MaxLength]
        public string DiaChiGiaoHang { get; set; }
        public string SoDienThoai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public DonHang()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
