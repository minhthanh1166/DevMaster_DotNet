using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Họ và tên người nhận")]
        [Required(ErrorMessage = "Họ tên người nhận không được để tróng!")]
        [StringLength(30)]
        public string? Name { get; set; }
        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống!")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng!")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng!")]
        [StringLength(14)]
        public string? Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [StringLength(100)]
        public string? Address { get; set; }
        [Display(Name = "Ghi chú")]
        [StringLength(500)]
        public string? Note { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreateDate { get; set; }
    }
}
