using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface ISubCategoryRepository:IRepository<SubCategory>
    {
        Task<SubCategory> GetWithProductByIdAsync(int scatId);
        Task<SubCategory> GetWithCategoryByIdAsync(int scatId);
        Task<IEnumerable<SubCategory>> GetAllWithCategoryAsync();
    }
}
