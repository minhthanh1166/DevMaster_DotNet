﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyWEB_API_Web.Data;

#nullable disable

namespace MyWEB_API_Web.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MyWEB_API_Web.Data.HangHoa", b =>
                {
                    b.Property<Guid>("MaHangHoa")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int?>("MaLoai")
                        .HasColumnType("int");

                    b.Property<int>("Ma_Loai")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHangHoa")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaHangHoa");

                    b.HasIndex("Ma_Loai");

                    b.ToTable("Hang_Hoa");
                });

            modelBuilder.Entity("MyWEB_API_Web.Data.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLoai"));

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("MyWEB_API_Web.Entity.DonHang", b =>
                {
                    b.Property<Guid>("MaDonHang")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChiGiaoHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayDat")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getutcdate()");

                    b.Property<DateTime?>("NgayGiao")
                        .HasColumnType("datetime2");

                    b.Property<string>("NguoiNhanHang")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TinhTrangDH")
                        .HasColumnType("int");

                    b.HasKey("MaDonHang");

                    b.ToTable("Don_Hang", (string)null);
                });

            modelBuilder.Entity("MyWEB_API_Web.Entity.DonHangChiTiet", b =>
                {
                    b.Property<Guid>("MaDonHang")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MaHangHoa")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("DonGia")
                        .HasColumnType("float");

                    b.Property<byte>("GiamGia")
                        .HasColumnType("tinyint");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaDonHang", "MaHangHoa");

                    b.HasIndex("MaHangHoa");

                    b.ToTable("Don_Hang_Chi_Tiet", (string)null);
                });

            modelBuilder.Entity("MyWEB_API_Web.Data.HangHoa", b =>
                {
                    b.HasOne("MyWEB_API_Web.Data.Loai", "loai")
                        .WithMany("HangHoas")
                        .HasForeignKey("Ma_Loai")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("loai");
                });

            modelBuilder.Entity("MyWEB_API_Web.Entity.DonHangChiTiet", b =>
                {
                    b.HasOne("MyWEB_API_Web.Entity.DonHang", "donHang")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaDonHang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DonHangCT_DonHang");

                    b.HasOne("MyWEB_API_Web.Data.HangHoa", "hangHoa")
                        .WithMany("DonHangChiTiets")
                        .HasForeignKey("MaHangHoa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_DonHangCT_HangHoa");

                    b.Navigation("donHang");

                    b.Navigation("hangHoa");
                });

            modelBuilder.Entity("MyWEB_API_Web.Data.HangHoa", b =>
                {
                    b.Navigation("DonHangChiTiets");
                });

            modelBuilder.Entity("MyWEB_API_Web.Data.Loai", b =>
                {
                    b.Navigation("HangHoas");
                });

            modelBuilder.Entity("MyWEB_API_Web.Entity.DonHang", b =>
                {
                    b.Navigation("DonHangChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
