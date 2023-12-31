﻿// <auto-generated />
using ChatOnlne.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ChatOnlne.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20230731132616_DbInit")]
    partial class DbInit
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ChatOnlne.Entity.Message", b =>
                {
                    b.Property<int>("ID_MSG")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_MSG"));

                    b.Property<int>("ID_USER")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_MSG");

                    b.HasIndex("ID_USER");

                    b.ToTable("Message", (string)null);
                });

            modelBuilder.Entity("ChatOnlne.Entity.User", b =>
                {
                    b.Property<int>("ID_USER")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_USER"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("nvarchar(70)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID_USER");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("ChatOnlne.Entity.Message", b =>
                {
                    b.HasOne("ChatOnlne.Entity.User", "user")
                        .WithMany("messages")
                        .HasForeignKey("ID_USER")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("ChatOnlne.Entity.User", b =>
                {
                    b.Navigation("messages");
                });
#pragma warning restore 612, 618
        }
    }
}
