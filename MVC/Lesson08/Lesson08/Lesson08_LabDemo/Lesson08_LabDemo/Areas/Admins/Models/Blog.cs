using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("Blog")]
    [Index(nameof(Name), IsUnique = true)]
    public class Blog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Tên blog")]
        [Required(ErrorMessage = "Tên blog không được để trống!")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Tên blog không được nhập quá 100 ký tự!")]
        public string? Name { get; set; }
        [Display(Name = "Trạng thái")]
        [DefaultValue(1)]
        public byte Status { get; set; } = 1;
        [Display(Name = "Lượt xem")]
        [DefaultValue(0)]
        public int VỉewCount { get; set; } = 0;
        [Display(Name = "Ngày tạo")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Hình ảnh")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Đường dẫn quá dài!")]
        [DataType(DataType.Upload)]
        public string? Image { get; set; }
        [Display(Name = "Nội dung")]
        [StringLength(1500)]
        [MaxLength(1500, ErrorMessage = "Nội dung không được nhập quá 350 ký tự!")]
        public string? Description { get; set; }
    }
}
