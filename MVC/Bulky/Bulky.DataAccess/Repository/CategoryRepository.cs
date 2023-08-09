
using Bulky.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Respository<Category>, ICategoryRepository
    {
        private readonly MyDBContext _context;
        public CategoryRepository(MyDBContext context) : base(context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Category obj)
        {
            _context.Categorys.Update(obj);
        }
    }
}
