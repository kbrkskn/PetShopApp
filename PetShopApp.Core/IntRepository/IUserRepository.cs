using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntRepository
{
    public interface IUserRepository:IRepository<User>
    {
        Task<User> GetWithOrderByIdAsync(int userId);
        Task<User> GetWithCommentByIdAsync(int userId);
    }
}
