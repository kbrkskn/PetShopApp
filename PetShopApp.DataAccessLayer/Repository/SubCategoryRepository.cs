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
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public SubCategoryRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<SubCategory> GetWithCategoryByIdAsync(int scatId)
        {
            var scategory = _db.SubCategories.Include(s => s.Category).FirstOrDefaultAsync(s => s.Id == scatId);
            return (await scategory)!;
        }

        public async Task<SubCategory> GetWithProductByIdAsync(int scatId)
        {
            var scategory = _db.SubCategories.Include(s =>s.Products).FirstOrDefaultAsync(s => s.Id == scatId);
            return (await scategory)!;
        }

        public async Task<IEnumerable<SubCategory>> GetAllWithCategoryAsync()
        {
            var scategories = _db.SubCategories.Include(s => s.Category).ToListAsync();
            return (await scategories);
        }
    }
}
