using Bulky.DataAccess;
using BulkyBook.DataAccess.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BulkyBook.DataAccess.Repository
{
    public class Respository<T> : IRespository<T> where T : class
    {
        private readonly MyDBContext _context;

        internal DbSet<T> DbSets;
        private MyDBContext context;

        public Respository(MyDBContext context)
        {
            _context = context;
            this.DbSets = _context.Set<T>();
            // Thực tế là _context.Category = dbSet
        }

        public Respository(MyDBContext context)
        {
            this.context = context;
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
