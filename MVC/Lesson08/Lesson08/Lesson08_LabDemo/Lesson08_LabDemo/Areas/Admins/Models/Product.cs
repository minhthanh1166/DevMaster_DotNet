using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("Product")]
    [Index(nameof(Name), IsUnique = true)]
    [Index(nameof(CategoryId), IsUnique = true)]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        [MinLength(6, ErrorMessage = "Tên sản phẩm ít nhất là 6 ký tự!")]
        [StringLength(100)]
        public string? Name { get; set; }
        [Display(Name = "Hình ảnh")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Đường dẫn quá dài!")]
        [DataType(DataType.Upload)]
        public string? Image { get; set; }
        [Display(Name = "Giá sản phẩm")]
        [Required(ErrorMessage = "Giá sản phẩm không được để trống!")]
        [Range(0, float.MaxValue, ErrorMessage = "Giá không được nhỏ hơn 0!")]
        public float Price { get; set; }
        [Display(Name = "Giá khuyến mãi")]
        [Range(0, float.MaxValue, ErrorMessage = "Giá không được nhỏ hơn 0!")]
        public float? SalePrice { get; set; }
        [Display(Name = "Trạng thái")]
        [DefaultValue(1)]
        public byte Status { get; set; } = 1;
        [Display(Name = "Mô tả sản phẩm")]
        [Required(ErrorMessage = "Mô tả sản phẩm không được để trống!")]
        [MinLength(6, ErrorMessage = "Mô tả sản phẩm ít nhất là 6 ký tự!")]
        [StringLength(1000)]
        public string? Description { get; set; }
        [Display(Name = "Ngày tạo")]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Tên loại")]
        [Required(ErrorMessage = "Tên loại không được để trống!")]
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        // Khoá ngoại tới bẳng category 
        public Category? Category { get; set; }
    }
}
