

using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRespository<Product>
    {
        void Update(Product obj);
    }
}
