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
    public class SubCategorySeed : IEntityTypeConfiguration<SubCategory>
    {
        //private readonly int[] _ids;
        private readonly int[] _ids;

        public SubCategorySeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(
                new SubCategory { Id = _ids[3], Name = "Kedi Maması", CategoryID = _ids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                 new SubCategory { Id = _ids[4], Name = "Kedi Kumu", CategoryID = _ids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                  new SubCategory { Id = _ids[5], Name = "Kedi Oyuncakları", CategoryID = _ids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _ids[6], Name = "Köpek Maması", CategoryID = _ids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _ids[7], Name = "Köpek Kıyafetleri", CategoryID = _ids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _ids[8], Name = "Köpek Oyuncakları", CategoryID = _ids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _ids[9], Name = "Kuş Yemi", CategoryID = _ids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                 new SubCategory { Id = _ids[10], Name = "Kuş Suluğu", CategoryID = _ids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                  new SubCategory { Id = _ids[1], Name = "Kuş Vitamini", CategoryID = _ids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                ); 
        }
    }
}
