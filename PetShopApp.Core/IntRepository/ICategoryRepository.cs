using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface ICategoryRepository:IRepository<Category>
    {
        Task<Category> GetWithSubCategoryByIdAsync(Guid catId);
    }
}
