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
        Task<Product> GetWithProductFeatureByIdAsync(int proId);
        Task<Product> GetWithOrderByIdAsync(int proId);
        Task<Product> GetWithCommentByIdAsync(int proId);
        Task<Product> GetWithSubCategoryByIdAsync(int proId);
        Task<IEnumerable<Product>> GetAllWithSubCategoryAsync();
    }
}
