using Microsoft.EntityFrameworkCore;
using PetShopApp.Core.IntRepository;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public CategoryRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<Category> GetWithSubCategoryByIdAsync(Guid catId)
        {
            var category = _db.Categories.Include(s => s.SubCategories).FirstOrDefaultAsync(s => s.Id == catId);
            return (await category)!;
        }
    }
}
