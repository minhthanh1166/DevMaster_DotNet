using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("Banner")]
    [Index(nameof(Name), IsUnique = true)]
    public class Banner
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Tên banner")]
        [Required(ErrorMessage = "Không được để trống!")]
        [StringLength(100)]
        public string? Name { get; set; }
        [Display(Name = "Trạng thái")]
        [DefaultValue(1)]
        public byte Status { get; set; } = 1;
        [Display(Name = "Độ ưu tiên banner")]
        [DefaultValue(0)]
        public int Prioty { get; set; } = 0;
        [Display(Name = "Hình ảnh")]
        [MaxLength(100, ErrorMessage = "Đường dẫn quá dài!")]
        [StringLength(100)]
        [DataType(DataType.Upload)]
        public string? Image { get; set; }
        [Display(Name = "Nội dung")]
        [MaxLength(350, ErrorMessage = "Nội dung quá dài!")]
        [StringLength(350)]
        public string? Description { get; set; }
        [Display(Name = "Ngày tạo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
    }
}
