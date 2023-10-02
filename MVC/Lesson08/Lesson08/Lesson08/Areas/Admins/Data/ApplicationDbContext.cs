using Lesson08.Models;
using Microsoft.EntityFrameworkCore;

namespace Lesson08.Areas.Admins.Data
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasMaxLength(11).HasColumnName("Id");

                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);
                entity.HasIndex(e => e.Name).IsUnique();

                entity.Property(e => e.Status).HasDefaultValue(1);

                entity.Property(e => e.CreateDate).HasDefaultValue(DateTime.Now);

                entity.Property(e => e.Image).IsRequired(false).HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired(false).HasColumnType("nvarchar(350)");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasMaxLength(11).HasColumnName("Id");

                entity.Property(e => e.Price).IsRequired();

                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.Property(e => e.SalePrice).HasDefaultValue(0);

                entity.Property(e => e.Status).HasDefaultValue(1);

                entity.Property(e => e.CategoryId).IsRequired();
                entity.HasOne(e => e.Category).WithMany(e => e.Products).HasForeignKey(e => e.CategoryId);

                entity.Property(e => e.CreateDate).HasDefaultValue(DateTime.Now);

                entity.Property(e => e.Image).IsRequired(false).HasMaxLength(100);

                entity.Property(e => e.Description).IsRequired(false).HasColumnType("nvarchar(350)");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("Banner");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasMaxLength(11).HasColumnName("Id");

                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(e => e.Name).IsRequired().HasMaxLength(100);

                entity.Property(e => e.status).HasDefaultValue(1);

                entity.Property(e => e.Prioty).HasDefaultValue(0);

                entity.Property(e => e.Image).HasMaxLength(100).IsRequired(false);

                entity.Property(e => e.Description).IsRequired(false).HasColumnType("nvarchar(350)");
            });

            modelBuilder.Entity<Blog>(entity =>
            {
                entity.ToTable("Blog");

                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id).ValueGeneratedOnAdd().HasMaxLength(11).HasColumnName("Id");

                entity.HasIndex(e => e.Name).IsUnique();
                entity.Property(e => e.Name).HasColumnName("Name").IsRequired().HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValue(1).HasColumnName("Status");

                entity.Property(e => e.CreateDate).HasDefaultValue(DateTime.Now);

                entity.Property(e => e.Image).HasMaxLength(100).IsRequired(false).HasColumnName("Image");

                entity.Property(e => e.Description).HasColumnType("nvarchar(350)").IsRequired(false).HasColumnName("Description");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
