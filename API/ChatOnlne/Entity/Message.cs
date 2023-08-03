using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatOnlne.Entity
{
    [Table("Message")]
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_MSG { get; set; }
        public string Text { get; set; }
        public int ID_USER { get; set; }
        [ForeignKey("ID_USER")]
        public User user { get; set; }

    }
}
