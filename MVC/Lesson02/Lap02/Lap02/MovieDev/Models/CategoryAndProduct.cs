using System.Numerics;

namespace MovieDev.Models
{
    public class CategoryAndProduct
    {
        public IEnumerable<Product> Product { get; set; }
        public IEnumerable<Category> Category { get; set; }
    }
}
