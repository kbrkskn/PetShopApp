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
    public class SubCategoryService : Service<SubCategory>, ISubCategoryService
    {
        public SubCategoryService(IUnitOfWork unit, IRepository<SubCategory> repo) : base(unit, repo)
        {
        }

        public async Task<SubCategory> GetWithCategoryByIdAsync(Guid scatId)
        {
            return await _unit.SubCategory.GetWithCategoryByIdAsync(scatId);
        }

        public async Task<SubCategory> GetWithProductByIdAsync(Guid scatId)
        {
            return await _unit.SubCategory.GetWithProductByIdAsync(scatId);
        }
    }
}
