using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.Id);
           // builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(p=>p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.SubCategoryID).IsRequired();
            builder.Property(p => p.Stock).IsRequired();
            builder.Property(p=>p.Brand).IsRequired();
            builder.Property(p=>p.Barcode).IsRequired();
            builder.HasOne(p => p.SubCategory).WithMany(c => c.Products).HasForeignKey(p => p.SubCategoryID);
            builder.ToTable("tblProducts");

        }
    }
}
