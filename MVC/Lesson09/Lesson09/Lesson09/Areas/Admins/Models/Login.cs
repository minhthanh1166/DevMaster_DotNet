using System.ComponentModel.DataAnnotations;

namespace Lesson09.Areas.Admins.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Địa chỉ email không được để trống!")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng!")]
        [Display(Name = "Địa chỉ email")]
        public required string Email { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        [Display(Name = "Mật khẩu")]
        public required string Password { get; set; }
        [Display(Name = "Nhớ thông tin đăng nhập")]
        public bool? Remember { get; set; }
    }
}
