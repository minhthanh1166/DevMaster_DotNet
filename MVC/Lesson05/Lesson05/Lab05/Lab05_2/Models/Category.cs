using System.ComponentModel.DataAnnotations;

namespace Lab05_2.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Tên Danh mục")]
        [MinLength(6, ErrorMessage = "Nhập ít nhất 6 ký tự!")]
        [MaxLength(150, ErrorMessage = "Nhập nhiều nhất 150 ký tự!")]
        public string Name { get; set; }
    }
}
