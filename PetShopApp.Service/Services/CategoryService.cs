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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public CategoryService(IUnitOfWork unit, IRepository<Category> repo) : base(unit, repo)
        {
        }

        public async Task<Category> GetWithProductByIdAsync(int catId)
        {
            return await _unit.Category.GetWithProductByIdAsync(catId);
        }

        public async Task<Category> GetWithSubCategoryByIdAsync(int catId)
        {
            return await _unit.Category.GetWithSubCategoryByIdAsync(catId);
        }
    }
}
