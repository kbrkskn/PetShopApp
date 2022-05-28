using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Seeds
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        //private readonly int[] _ids;
        private readonly int[] _ids;

        public CategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category { Id = _ids[0], Name = "Kedi" , CreatedDate=DateTime.Now, ModifiedDate=DateTime.Now},
                new Category { Id = _ids[1], Name = "Köpek", CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new Category { Id = _ids[2], Name = "Kuş" , CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                );
        }
    }
}
