using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson07.Models
{
    public class Banner
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Không được để trống!")]
        [Display(Name = "Tên")]
        public string? Name { get; set; }
        [Display(Name = "Trạng thái")]
        public byte status { get; set; } = 1;
        [Display(Name = "Ưu tiên banner")]
        public int Prioty { get; set; } = 0;
        [Display(Name = "Hình ảnh")]
        [MaxLength(100, ErrorMessage = "Không được nhâp")]
        public string? Image { get; set; }
        [Display(Name = "Nội dung")] 
        public string? Description { get; set; }
    }
}
