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
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public OrderRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<Order> GetWithProductByIdAsync(Guid orderId)
        {
            var order = _db.Orders.Include(s => s.Product).FirstOrDefaultAsync(s => s.Id == orderId);
            return (await order)!;
        }

        public async Task<Order> GetWithUserByIdAsync(Guid orderId)
        {
            var order = _db.Orders.Include(s => s.User).FirstOrDefaultAsync(s => s.Id == orderId);
            return (await order)!;
        }
    }
}
