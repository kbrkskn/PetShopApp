using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Configurations
{
    public class DiscountedProductConfiguration:IEntityTypeConfiguration<DiscountedProduct>
    {
        public void Configure(EntityTypeBuilder<DiscountedProduct> builder )
        {
            builder.HasKey(p => p.Id);
            //builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(200);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(18,2)");
            builder.Property(p => p.Percent).IsRequired().HasColumnType("int");
            builder.Property(p => p.ProductID).IsRequired();
            builder.HasOne(p => p.Product).WithMany(c => c.DiscountedProducts).HasForeignKey(p => p.ProductID);
            builder.ToTable("tblDiscountedProduct");
        }
        
    }
}
