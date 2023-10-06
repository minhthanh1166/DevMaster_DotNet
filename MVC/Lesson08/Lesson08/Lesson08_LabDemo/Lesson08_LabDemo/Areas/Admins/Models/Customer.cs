using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Lesson08_LabDemo.Areas.Admins.Models
{
    [Table("Customer")]
    [Index(nameof(Username), IsUnique = true)]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống!")]
        [MinLength(6, ErrorMessage = "Họ tên ít nhất là 6 ký tự!")]
        [MaxLength(20, ErrorMessage = "Họ tên tối đa 20 ký tự!")]
        [StringLength(20)]
        public string? Name { get; set; }
        [Display(Name = "Địa chỉ email")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống!")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng!")]
        [StringLength(100)]
        public string? Email { get; set; }
        [Display(Name = "Ảnh đại diện")]
        [StringLength(100)]
        [MaxLength(100, ErrorMessage = "Đường dẫn quá dài!")]
        [DataType(DataType.Upload)]
        public string? Image { get; set; }
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống!")]
        [MinLength(6, ErrorMessage = "Tên đăng nhập ít nhất là 6 ký tự!")]
        [MaxLength(30, ErrorMessage = "Tên đăng nhập tối đa 20 ký tự!")]
        [StringLength(30)]
        public string? Username { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu không được để trống!")]
        [MinLength(6, ErrorMessage = "Mật khẩu ít nhất là 6 ký tự!")]
        [DataType(DataType.Password)]
        [MaxLength(100, ErrorMessage = "Mật khẩu không được dài quá 100 ký tự!")]
        [StringLength(100)]
        public string? Password { get; set; }
        [Display(Name = "Link facebook cá nhân")]
        [Required(AllowEmptyStrings = true)]
        [MaxLength(500, ErrorMessage = "Link facebook của bạn quá dài!")]
        [StringLength(500)]
        public string? Facebook { get; set; }
        [Display(Name = "Ngày tạo")]
        public DateTime? CreateDate { get; set; }
        [Display(Name = "Trạng thái")]
        [DefaultValue(1)]
        public byte Status { get; set; } = 1;
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [MinLength(6, ErrorMessage = "Địa chỉ ít nhất là 6 ký tự!")]
        [MaxLength(100, ErrorMessage = "Địa chỉ tối đa 100 ký tự!")]
        [StringLength(100)]
        public string? Address { get; set; }
        [Display(Name = "Số điện thoại")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        [MinLength(10, ErrorMessage = "Số điện thoại ít nhất là 10 ký tự!")]
        [MaxLength(14, ErrorMessage = "Số điện thoại tối đa 10 ký tự!")]
        [StringLength(14)]
        [DataType(DataType.PhoneNumber)]
        public string? Phone { get; set; }
        [Display(Name = "Giới tính")]
        [DefaultValue(0)]
        public int? Gender { get; set; } = 0;
    }
}
