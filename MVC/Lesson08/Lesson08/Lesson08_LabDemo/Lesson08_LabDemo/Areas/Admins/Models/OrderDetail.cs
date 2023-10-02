using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("OrderDetail")]
    [Index(nameof(OrderId), IsUnique = true)]
    [Index(nameof(ProductId), IsUnique = true)]
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Tên đơn hàng")]
        [Required(ErrorMessage = "Mã đơn hàng không được để trống!")]
        [ForeignKey("OrderId")]
        public int OrderId { get; set; }
        public virtual required Order Order { get; set; }
        [ForeignKey("ProductId")]
        [Display(Name = "Tên sản phẩm")]
        [Required(ErrorMessage = "Mã sản phẩm không được để trống!")]
        public int ProductId { get; set; }
        public virtual required Product Product { get; set; }
        [Display(Name = "Số lượng")]
        [Required(ErrorMessage = "Số lượng không được để trống!")]
        public int Quantity { get; set; }
        [Display(Name = "Giá")]
        [Required(ErrorMessage = "Giá không được để trống!")]
        [Range(0, float.MaxValue, ErrorMessage = "Giá không được nhỏ hơn 0!")]
        public float Price { get; set; }
    }
}
