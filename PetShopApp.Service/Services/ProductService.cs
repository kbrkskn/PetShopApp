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
    public class ProductService : Service<Product>, IProductService
    {
        public ProductService(IUnitOfWork unit, IRepository<Product> repo) : base(unit, repo)
        {
        }

        public Task<IEnumerable<Product>> GetAllWithSubCategoryAsync()
        {
           return _unit.Product.GetAllWithSubCategoryAsync();
        }

        public async Task<Product> GetWithOrderByIdAsync(Guid proId)
        {
            return await _unit.Product.GetWithOrderByIdAsync(proId);
        }

        public async Task<Product> GetWithProductFeatureByIdAsync(Guid proId)
        {
            return await _unit.Product.GetWithProductFeatureByIdAsync(proId);
        }

        public async Task<Product> GetWithSubCategoryByIdAsync(Guid proId)
        {
            return await _unit.Product.GetWithSubCategoryByIdAsync(proId);
        }
    }
}
