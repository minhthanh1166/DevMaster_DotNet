using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson06_code_first.Models
{
    [Table("Categories")]
    public class Category
    {
        [DisplayName("Mã loại")]
        public int CategoryId { get; set; }
        [DisplayName("Tên loại")]
        [StringLength(100)]
        public string CategooryName { get; set; }

        // Thuộc tính quan hệ
        public ICollection<Book> Books { get; set; }
    }
}
