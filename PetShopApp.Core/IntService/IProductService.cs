using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface IProductService:IService<Product>
    {
        Task<Product> GetWithProductFeatureByIdAsync(Guid proId);
        Task<Product> GetWithOrderByIdAsync(Guid proId);
        Task<Product> GetWithSubCategoryByIdAsync(Guid proId);
        Task<IEnumerable<Product>> GetAllWithSubCategoryAsync();
    }
}
