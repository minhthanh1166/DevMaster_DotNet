namespace Lab09.Models
{
    public class OrderCart
    {
        public float Carts { get; set; }
        public IEnumerable<Cart> ListCarts { get; set; }
    }
}
