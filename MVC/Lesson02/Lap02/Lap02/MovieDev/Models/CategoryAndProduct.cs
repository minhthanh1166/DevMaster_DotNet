using System.Numerics;

namespace MovieDev.Models
{
    public class CategoryAndProduct
    {
        public IEnumerable<Product> ListProduct { get; set; }
        public IEnumerable<Category> ListCategory { get; set; }
        public string NameCategory { get; set; }
     
    }
}
