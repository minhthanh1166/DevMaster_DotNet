using Lesson08_LabDemo.Areas.Admins.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson08_LabDemo.Areas.Admins.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Banner> Banners { get; set; }
        public virtual DbSet<Category> Categorys { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(x => x.CreateDate).HasDefaultValue(DateTime.Now);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
