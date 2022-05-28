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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public ProductRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<Product> GetWithOrderByIdAsync(int proId)
        {
            var product = _db.Products.Include(s => s.Orders).FirstOrDefaultAsync(s => s.Id == proId);
            return (await product)!;
        }

        public async Task<Product> GetWithProductFeatureByIdAsync(int proId)
        {
            var product = _db.Products.Include(s => s.ProductFeatures).FirstOrDefaultAsync(s => s.Id == proId);
            return (await product)!;
        }

        public async Task<Product> GetWithSubCategoryByIdAsync(int proId)
        {
            var product = _db.Products.Include(s => s.SubCategory).FirstOrDefaultAsync(s => s.Id == proId);
            return (await product)!;
        }

        public async Task<IEnumerable<Product>> GetAllWithSubCategoryAsync()
        {
            var products = _db.Products.Include(s => s.SubCategory).ToListAsync();
            return (await products);
        }

        public async Task<Product> GetWithCommentByIdAsync(int proId)
        {
            var product= _db.Products.Include(s => s.Comments).FirstOrDefaultAsync(s=>s.Id==proId);
            return (await product);
        }
    }
}
