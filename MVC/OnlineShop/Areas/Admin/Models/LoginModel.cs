using System.ComponentModel.DataAnnotations;

namespace OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required]
        public string userName { get; set; }
        public string passWord { get; set; }
        public bool rememBerMe { get; set; }
    }
}