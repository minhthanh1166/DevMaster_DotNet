using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Lesson08.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MaxLength(100, ErrorMessage = "Không được nhập quá 100 ký tự!")]
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Tên sản phẩm không được để trống!")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Không được để trống giá bán!")]
        [Display(Name = "Giá bán")]
        public float Price { get; set; }
        [Required(ErrorMessage = "Không được để trống giảm giá")]
        [Display(Name = "Giảm giá")]
        public float SalePrice { get; set; } = 0;
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;
        public virtual required Category Category { get; set; }
        [Display(Name = "Tên loại")]
        public int CategoryId { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Hình ảnh")]
        [MaxLength(100, ErrorMessage = "Ký tự không được quá 100")]
        public string Image { get; set; }
        [Display(Name = "Nội dung")]
        [MaxLength(350, ErrorMessage = "Ký tự không được quá 350")]
        public string Description { get; set; }
    }
}
