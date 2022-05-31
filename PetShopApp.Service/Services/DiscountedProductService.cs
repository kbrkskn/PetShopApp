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
    public class DiscountedProductService : Service<DiscountedProduct>, IDiscountedProductService
    {
        public DiscountedProductService(IUnitOfWork unit, IRepository<DiscountedProduct> repo) : base(unit, repo)
        {
        }

        public async Task<DiscountedProduct> GetWithProductByIdAsync(int disproid)
        {
            return await _unit.DiscountedProduct.GetWithProductByIdAsync(disproid);
        }
    }
}
