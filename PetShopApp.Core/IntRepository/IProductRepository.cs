using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product> GetWithProductFeatureByIdAsync(Guid proId);
        Task<Product> GetWithOrderByIdAsync(Guid proId);
        Task<Product> GetWithSubCategoryByIdAsync(Guid proId);
        Task<IEnumerable<Product>> GetAllWithSubCategoryAsync();
    }
}
