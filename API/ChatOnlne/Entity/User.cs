using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatOnlne.Entity
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_USER { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(70)]
        public string Email { get; set; }
        [MaxLength(50)]
        [Required]
        public string UserName { get; set; }
        [MaxLength(50)]
        [Required]
        public string Password { get; set; }

        // Mối quan hệ 1-nhiều với Message
        public ICollection<Message> messages { get; set; }
    }
}
