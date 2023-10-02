using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Display(Name = "Tên")]
        [Required(ErrorMessage = "Tên không được để trống!")]
        public string Name { get; set; }
        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;
        [Display(Name = "Ngày tạo")]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Hình ảnh")]
        public string Image { get; set; }
        [Display(Name = "Nội dung")]
        public string Description { get; set; }
    }
}
