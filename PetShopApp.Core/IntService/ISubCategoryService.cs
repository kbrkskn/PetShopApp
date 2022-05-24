using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface ISubCategoryService:IService<SubCategory>
    {
        Task<SubCategory> GetWithProductByIdAsync(Guid scatId);
        Task<SubCategory> GetWithCategoryByIdAsync(Guid scatId);
    }
}
