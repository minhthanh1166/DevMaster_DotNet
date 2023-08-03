using System.ComponentModel.DataAnnotations;

namespace ChatOnlne.Models
{
    public class UserModel
    {
        public int ID_USER { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
