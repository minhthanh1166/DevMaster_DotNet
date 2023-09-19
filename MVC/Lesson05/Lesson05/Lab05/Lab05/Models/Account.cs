using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab05.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Họ và tên: ")]
        [Required(ErrorMessage = "Họ không được để trống!")]
        [MinLength(6, ErrorMessage = "Họ ít nhất là 6 kí tự!")]
        [MaxLength(20, ErrorMessage = "Họ nhiều nhất là 20 ký tự!")]
        public string FullName { get; set; }


        [Display(Name = "Địa chỉ email: ")]
        [Required(ErrorMessage = "Địa chỉ email không được để trống!")]
        [EmailAddress(ErrorMessage = "Địa chỉ email không đúng định dạng!")]
        public string Email { get; set; }


        [Display(Name = "Số điện thoại: ")]
        [DataType(DataType.PhoneNumber)]
        // [RegularExpression(@"^(84|0[3|5|7|8|9])+([0-9]{8})\b$", ErrorMessage = "Số điện thoại không đúng định dạng!")]
        [Remote(action: "VarifyPhone", controller: "Account")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string Phone { get; set; }


        [Display(Name = "Địa chỉ thường trú: ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        [StringLength(35, ErrorMessage = "Địa chỉ không được vượt quá 35 ký tự!")]
        public string Address { get; set; }


        [Display(Name = "Ảnh đại diện: ")]
        [Required(AllowEmptyStrings = true)]
        public string Avatar { get; set; }


        [Display(Name = "Ngày sinh: ")]
        [Required(ErrorMessage = "Ngày sinh không được để trống!")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }


        [Display(Name = "Giới tính: ")]
        public string Gender { get; set; } // Consider using an enum


        [Display(Name = "Mật khẩu: ")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Link Facebook cá nhân: ")]
        [Required(ErrorMessage = "Link Facebook không được để trống!")]
        [Url(ErrorMessage = "Link facebook phải đúng định dạng!")]
        public string Facebook { get; set; }
    }
}
