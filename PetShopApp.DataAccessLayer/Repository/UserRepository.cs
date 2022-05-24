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
    public class UserRepository : Repository<User>, IUserRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public UserRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<User> GetWithCommentByIdAsync(Guid userId)
        {
            var user = _db.Users.Include(s => s.Comments).FirstOrDefaultAsync(s => s.Id == userId);
            return (await user)!;
        }

        public async Task<User> GetWithOrderByIdAsync(Guid userId)
        {
            var user = _db.Users.Include(s => s.Orders).FirstOrDefaultAsync(s => s.Id == userId);
            return (await user)!;
        }
    }
}
