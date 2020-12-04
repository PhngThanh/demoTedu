using Demo.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Data.configurations
{
    class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products"); // gen ra sql tên bảng Product
            builder.HasKey(x => x.Id); // set khóa chính
            builder.Property(x => x.Note).IsRequired(true); //not null
            //khóa ngoại 
        }
    }
}
