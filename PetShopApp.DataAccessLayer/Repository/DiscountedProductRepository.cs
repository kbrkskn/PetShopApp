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
    public class DiscountedProductRepository : Repository<DiscountedProduct>, IDiscountedProductRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public DiscountedProductRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<DiscountedProduct> GetWithProductByIdAsync(int disproid)
        {
            var dispro= _db.DiscountedProducts.Include(s => s.Product).FirstOrDefaultAsync(s => s.Id == disproid);
            return (await dispro)!;
        }
    }
}
