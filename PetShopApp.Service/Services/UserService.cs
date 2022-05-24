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
    public class UserService : Service<User>, IUserService
    {
        public UserService(IUnitOfWork unit, IRepository<User> repo) : base(unit, repo)
        {
        }

        public async Task<User> GetWithCommentByIdAsync(Guid userId)
        {
           return await _unit.User.GetWithCommentByIdAsync(userId);
        }

        public async Task<User> GetWithOrderByIdAsync(Guid userId)
        {
            return await _unit.User.GetWithOrderByIdAsync(userId);
        }
    }
}
