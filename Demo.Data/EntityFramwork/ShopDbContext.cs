using Demo.Data.configurations;
using Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.EntityFramwork
{
    public class ShopDbContext : DbContext
    {
        public ShopDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfig());

            //base.OnModelCreating(modelBuilder);
        }
        //khai báo entity
        //bao nhiêu entity khai báo bấy nhiêu
        public DbSet<Product> Products { get; set; }

        //ccaaus hình quan hệ
        //confi entity
        //1. Attribute confi
        //2. Fluent API - k động class mà confi ở ngoài
    }
}
