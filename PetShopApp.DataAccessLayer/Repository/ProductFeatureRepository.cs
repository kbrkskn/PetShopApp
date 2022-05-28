using Microsoft.EntityFrameworkCore;
using PetShopApp.Core.IntRepository;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Repository
{
    public class ProductFeatureRepository : Repository<ProductFeature>, IProductFeatureRepository
    {
        public ProductFeatureRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<ProductFeature> GetWithProductByIdAsync(int profId)
        {
            var prof = _db.ProductFeatures.Include(s => s.Product).FirstOrDefaultAsync(s => s.Id == profId);
            return (await prof)!;

        }
    }
}
