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
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p=>p.Id);
            builder.Property(p=>p.UserID).IsRequired();
            builder.Property(p => p.ProductID).IsRequired();
            builder.HasOne(p => p.User).WithMany(c => c.Orders).HasForeignKey(p => p.UserID);
            builder.HasOne(p => p.Product).WithMany(c => c.Orders).HasForeignKey(p => p.ProductID);
            builder.ToTable("tblOrders");

        }
    }
}
