using System.ComponentModel.DataAnnotations;

namespace Lab09.Models
{
    public class Customer
    {

        public int Id { get; set; }
        [Display(Name = "Họ và tên")]
        [Required(ErrorMessage = "Họ và tên không được để trống")]
        public string? Name { get; set; }
        [EmailAddress(ErrorMessage = "Email không đúng định dạng!")]
        [Display(Name = "Địa chi Email")]
        public string? Email { get; set; }
        [Display(Name = "Số điện thoại")]
        [Phone(ErrorMessage = "Số điện thoại không đúng định dạng!")]
        [Required(ErrorMessage = "Số điện thoại không được để trống!")]
        public string? Phone { get; set; }
        [Display(Name = "Địa chỉ")]
        [Required(ErrorMessage = "Địa chỉ không được để trống!")]
        public string? Address { get; set; }
        [Display(Name = "Tỉnh/Thành phố")]
        [Required(ErrorMessage = "Không được để trống!")]
        public string? City { get; set; }
        [Display(Name = "Quận/ Huyện")]
        [Required(ErrorMessage = "Không được để trống!")]
        public string? District { get; set; }
        [Display(Name = "Ghi chú")]
        public string? Description { get; set; }
    }
}
