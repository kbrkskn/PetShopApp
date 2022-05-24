using PetShopApp.Core.IntRepository;
using PetShopApp.Core.IntService;
using PetShopApp.Core.IntUnitOfWork;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Service.Services
{
    public class ProductFeatureService : Service<ProductFeature>, IProductFeatureService
    {
        public ProductFeatureService(IUnitOfWork unit, IRepository<ProductFeature> repo) : base(unit, repo)
        {
        }

        public async Task<ProductFeature> GetWithProductByIdAsync(Guid profId)
        {
            return await _unit.ProductFeature.GetWithProductByIdAsync(profId);
        }
    }
}
