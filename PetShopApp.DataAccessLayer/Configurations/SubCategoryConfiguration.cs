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
    public class SubCategoryConfiguration : IEntityTypeConfiguration<SubCategory>

    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(p => p.Id);
           //builder.Property(x => x.Id).UseIdentityColumn() ;
            builder.Property(p => p.Name).IsRequired().HasMaxLength(20);
            builder.Property(p => p.CategoryID).IsRequired();
            builder.HasOne(p => p.Category).WithMany(c => c.SubCategories).HasForeignKey(p => p.CategoryID);
            builder.ToTable("tblSubCategories");
        }
    }
}
