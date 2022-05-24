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
        private readonly Guid[] _guids;
        public ProductFeatureSeed(Guid[] guids)
        {
            _guids = guids;
        }
        public void Configure(EntityTypeBuilder<ProductFeature> builder)
        {
            builder.HasData(
                new ProductFeature
                {
                    Id = _guids[15],
                    Feature = "Açıklama 1",
                    ProductID = _guids
                [12],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _guids[16],
                    Feature = "Açıklama 2",
                    ProductID = _guids
                [12],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _guids[17],
                    Feature = "Açıklama 1",
                    ProductID = _guids
                [13],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _guids[18],
                    Feature = "Açıklama 2",
                    ProductID = _guids
                [13],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _guids[19],
                    Feature = "Açıklama 1",
                    ProductID = _guids
                [14],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                },
                new ProductFeature
                {
                    Id = _guids[20],
                    Feature = "Açıklama 2",
                    ProductID = _guids
                [14],
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now
                }
                );
                
        }
    }
}
