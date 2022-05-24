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

        public async Task<SubCategory> GetWithCategoryByIdAsync(Guid scatId)
        {
            var scategory = _db.SubCategories.Include(s => s.Category).FirstOrDefaultAsync(s => s.Id == scatId);
            return (await scategory)!;
        }

        public async Task<SubCategory> GetWithProductByIdAsync(Guid scatId)
        {
            var scategory = _db.SubCategories.Include(s =>s.Products).FirstOrDefaultAsync(s => s.Id == scatId);
            return (await scategory)!;
        }
    }
}
