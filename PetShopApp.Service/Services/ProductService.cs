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

        public async Task<Product> GetWithCommentByIdAsync(int proId)
        {
            return await _unit.Product.GetWithCommentByIdAsync(proId);
        }

        public async Task<Product> GetWithOrderByIdAsync(int proId)
        {
            return await _unit.Product.GetWithOrderByIdAsync(proId);
        }

        public async Task<Product> GetWithProductFeatureByIdAsync(int proId)
        {
            return await _unit.Product.GetWithProductFeatureByIdAsync(proId);
        }

        public async Task<Product> GetWithSubCategoryByIdAsync(int proId)
        {
            return await _unit.Product.GetWithSubCategoryByIdAsync(proId);
        }
    }
}
