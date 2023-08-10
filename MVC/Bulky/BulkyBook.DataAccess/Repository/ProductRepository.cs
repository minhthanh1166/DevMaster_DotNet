using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Respository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Product obj)
        {
            var objFormDb = _db.Products.FirstOrDefault(u => u.Id == obj.Id);
            if (objFormDb != null)
            {
                objFormDb.Title = obj.Title;
                objFormDb.ISBN = obj.ISBN;
                objFormDb.Price = obj.Price;
                objFormDb.Price50 = obj.Price50;
                objFormDb.Price100 = obj.Price100;
                objFormDb.ListPrice = obj.ListPrice;
                objFormDb.Description = obj.Description;
                objFormDb.CategoryId = obj.CategoryId;
                objFormDb.Author = obj.Author;
                if (obj.ImageUrl != null)
                {
                    objFormDb.ImageUrl = obj.ImageUrl;
                }
            }
        }
    }
}
