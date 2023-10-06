using Lesson09.Areas.Admins.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Lesson09.Areas.Admins.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
