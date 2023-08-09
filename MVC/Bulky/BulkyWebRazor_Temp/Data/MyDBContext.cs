﻿using BulkyWebRazor_Temp.Models;
using Microsoft.EntityFrameworkCore;

namespace BulkyWebRazor_Temp.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }

        public DbSet<Category> Categorys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
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
