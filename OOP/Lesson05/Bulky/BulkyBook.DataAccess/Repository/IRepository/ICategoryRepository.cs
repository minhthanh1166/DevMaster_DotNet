

using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRespository<Category>
    {
        void Update(Category obj);
    }
}
