using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface IUserService:IService<User>
    {
        Task<User> GetWithOrderByIdAsync(Guid userId);
        Task<User> GetWithCommentByIdAsync(Guid userId);
    }
}
