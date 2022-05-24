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
        private readonly Guid[] _guids;

        public SubCategorySeed(Guid[] guids)
        {
            _guids = guids;
        }
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasData(
                new SubCategory { Id = _guids[3], Name = "Kedi Maması", CategoryID = _guids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                 new SubCategory { Id = _guids[4], Name = "Kedi Kumu", CategoryID = _guids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                  new SubCategory { Id = _guids[5], Name = "Kedi Oyuncakları", CategoryID = _guids[0], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _guids[6], Name = "Köpek Maması", CategoryID = _guids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _guids[7], Name = "Köpek Kıyafetleri", CategoryID = _guids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _guids[8], Name = "Köpek Oyuncakları", CategoryID = _guids[1], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                new SubCategory { Id = _guids[9], Name = "Kuş Yemi", CategoryID = _guids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                 new SubCategory { Id = _guids[10], Name = "Kuş Suluğu", CategoryID = _guids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now },
                  new SubCategory { Id = _guids[1], Name = "Kuş Vitamini", CategoryID = _guids[2], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now }
                ); 
        }
    }
}
