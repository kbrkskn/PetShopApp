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
    public class ProductFeatureSeed : IEntityTypeConfiguration<ProductFeature>
    {
       // private readonly int[] _ids;
        private readonly int[] _ids;
        public ProductFeatureSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = _ids[15],
                    Feature = "Açıklama 1",
                    ProductID = _ids
                [12],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _ids[16],
                    Feature = "Açıklama 2",
                    ProductID = _ids
                [12],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _ids[17],
                    Feature = "Açıklama 1",
                    ProductID = _ids
                [13],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _ids[18],
                    Feature = "Açıklama 2",
                    ProductID = _ids
                [13],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _ids[19],
                    Feature = "Açıklama 1",
                    ProductID = _ids
                [14],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _ids[20],
                    Feature = "Açıklama 2",
                    ProductID = _ids
                [14],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
                );
                
        }
    }
}
