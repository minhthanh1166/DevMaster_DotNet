

using BulkyBook.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> option) : base(option)
        {

        }

        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Tạo data trong csdl
            modelBuilder.Entity<Category>().HasData(
                    new Category
                    {
                        Id = 1,
                        Name = "Action",
                        DisplayOrder = 1
                    },
                       new Category
                       {
                           Id = 2,
                           Name = "SciFi",
                           DisplayOrder = 2
                       },
                          new Category
                          {
                              Id = 3,
                              Name = "History",
                              DisplayOrder = 3
                          }
                );
        }
    }
}
