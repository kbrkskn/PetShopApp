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
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(p => p.Id);
            //builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(15);
            builder.Property(p=>p.LastName).IsRequired().HasMaxLength(15);
            builder.Property(p=>p.Email).IsRequired().HasMaxLength(50);
            builder.Property(p=>p.Password).IsRequired().HasMaxLength(10);
            builder.Property(p => p.Phone).IsRequired().HasMaxLength(11);
            builder.ToTable("tblUsers");
        }
    }
}
