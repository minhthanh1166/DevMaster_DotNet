using BulkyBook.DataAccess.Data;
using BulkyBook.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository
{
    public class Respository<T> : IRespository<T> where T : class
    {
        private readonly ApplicationDbContext _db;

        internal DbSet<T> DbSets;

        public Respository(ApplicationDbContext context)
        {
            _db = context;
            this.DbSets = _db.Set<T>();
            // Thực tế là _db.Category = dbSet
        }

        public void Add(T entity)
        {
            DbSets.Add(entity);
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = DbSets;
            query = query.Where(filter);
            return query.FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = DbSets;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            DbSets.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            DbSets.RemoveRange(entity);
        }
    }
}
