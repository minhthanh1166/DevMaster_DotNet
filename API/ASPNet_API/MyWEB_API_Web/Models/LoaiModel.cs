using System.ComponentModel.DataAnnotations;

namespace MyWEB_API_Web.Models
{
    public class LoaiModel
    {
        [Required]
        [MaxLength(50)]
        public string TenLoai { get; set; }
    }
}
