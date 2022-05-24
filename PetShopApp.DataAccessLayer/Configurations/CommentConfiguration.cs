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
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
           builder.HasKey(p => p.Id);
            //builder.Property(x=>x.Id).UseIdentityColumn();
            builder.Property(p => p.Text).IsRequired().HasMaxLength(200);
            builder.Property(p => p.ProductID).IsRequired();
            builder.Property(p => p.UserID).IsRequired();
            builder.HasOne(p => p.User).WithMany(c => c.Comments).HasForeignKey(p => p.UserID);
            builder.HasOne(p => p.Product).WithMany(c => c.Comments).HasForeignKey(p => p.ProductID);
            builder.ToTable("tblComments");
        }
    }
}
