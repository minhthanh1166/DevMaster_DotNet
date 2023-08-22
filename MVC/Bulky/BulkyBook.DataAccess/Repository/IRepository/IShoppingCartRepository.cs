

using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IShoppingCartRepository : IRespository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
