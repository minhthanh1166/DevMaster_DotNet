using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Display(Name = "Tên loại")]
        [MaxLength(200, ErrorMessage = "Không được nhập quá 200 ký tự!")]
        [Required(ErrorMessage = "Tên loại không được để trống!")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Hình ảnh")]
        [MaxLength(100, ErrorMessage = "Ký tự không được quá 100")]
        public string Image { get; set; }
        [Display(Name = "Nội dung")]
        [MaxLength(350, ErrorMessage = "Ký tự không được quá 350")]
        public string Description { get; set; }
        public virtual ICollection<Product> Products { get; set;} = new List<Product>();
    }
}