using MyWEB_API_Web.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWEB_API_Web.Data
{
    [Table("Hang_Hoa")]
    public class HangHoa
    {
        [Key]
        public Guid MaHangHoa { get; set; }
        [Required]
        [MaxLength(100)]
        public string TenHangHoa { get; set; }
        [MaxLength]
        public string MoTa { get; set; }
        [Range(0, double.MaxValue)]
        public double DonGia { get; set; }
        [Range(0, double.MaxValue)]
        public byte GiamGia { get; set; }
        public int? MaLoai { get; set; }

        [ForeignKey("Ma_Loai")]
        public Loai loai { get; set; }

        public ICollection<DonHangChiTiet> DonHangChiTiets { get; set; }
        public HangHoa()
        {
            DonHangChiTiets = new List<DonHangChiTiet>();
        }
    }
}
