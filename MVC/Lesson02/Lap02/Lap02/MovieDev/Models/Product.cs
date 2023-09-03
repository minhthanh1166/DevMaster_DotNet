namespace MovieDev.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public double SalePrice { get; set;}
        public Category categoryId { get; set; }
        public string Description { get; set; }
        public bool status { get; set; }
        public DateTime createAt { get; set; }
    }
}
