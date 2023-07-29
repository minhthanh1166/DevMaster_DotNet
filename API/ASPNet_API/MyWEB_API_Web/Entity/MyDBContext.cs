using Microsoft.EntityFrameworkCore;
using MyWEB_API_Web.Entity;

namespace MyWEB_API_Web.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options)
        {

        }

        #region DbSet
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }

        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.ToTable("Don_Hang");
                entity.HasKey(dh => dh.MaDonHang);
                entity.Property(dh => dh.NgayDat).HasDefaultValueSql("getutcdate()");
                entity.Property(dh => dh.NguoiNhanHang).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<DonHangChiTiet>(entity =>
            {
                entity.ToTable("Don_Hang_Chi_Tiet");
                entity.HasKey(e => new { e.MaDonHang, e.MaHangHoa });
                entity.HasOne(e => e.donHang)
                    .WithMany(e => e.DonHangChiTiets)
                    .HasForeignKey(e => e.MaDonHang)
                    .HasConstraintName("FK_DonHangCT_DonHang");

                entity.HasOne(e => e.hangHoa)
                    .WithMany(e => e.DonHangChiTiets)
                    .HasForeignKey(e => e.MaHangHoa)
                    .HasConstraintName("FK_DonHangCT_HangHoa");
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
