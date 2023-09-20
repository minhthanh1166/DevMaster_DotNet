using Lesson06_code_first.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson06_code_first.Entities
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; } 
        public DbSet<Lesson06_code_first.Models.Publisher> Publisher { get; set; }
    }
}
