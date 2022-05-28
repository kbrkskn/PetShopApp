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
        Task<Product> GetWithProductFeatureByIdAsync(int proId);
        Task<Product> GetWithOrderByIdAsync(int proId);
        Task<Product> GetWithCommentByIdAsync(int proId);
        Task<Product> GetWithSubCategoryByIdAsync(int proId);
        Task<IEnumerable<Product>> GetAllWithSubCategoryAsync();
    }
}
