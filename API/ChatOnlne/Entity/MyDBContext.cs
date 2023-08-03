using Microsoft.EntityFrameworkCore;

namespace ChatOnlne.Entity
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options) { }

        #region DbSet
        public virtual DbSet<User> USERS { get; set; }
        public virtual DbSet<Message> MESSAGES { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Định nghĩa mối quan hệ 1-nhiều giữa Account và Message
            // Cấu hình tên bảng và khóa chính cho User
            modelBuilder.Entity<User>()
                .ToTable("User")
                .HasKey(u => u.ID_USER);

            // Cấu hình tên bảng và khóa chính cho Message
            modelBuilder.Entity<Message>()
                .ToTable("Message")
                .HasKey(m => m.ID_MSG);

            // Cấu hình mối quan hệ 1-nhiều giữa User và Message
            modelBuilder.Entity<Message>()
                .HasOne(m => m.user)
                .WithMany(u => u.messages)
                .HasForeignKey(m => m.ID_USER);
        }
        #endregion
    }
}
