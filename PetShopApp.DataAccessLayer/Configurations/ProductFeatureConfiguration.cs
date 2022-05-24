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
    public class ProductFeatureConfiguration : IEntityTypeConfiguration<ProductFeature>
    {
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasKey(p => p.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.Feature).IsRequired().HasMaxLength(250);
            builder.Property(p => p.ProductID).IsRequired();
            builder.HasOne(p => p.Product).WithMany(c => c.ProductFeatures).HasForeignKey(p => p.ProductID);
            builder.ToTable("tblProductFeatures");
        }
    }
}
