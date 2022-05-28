using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.IntService
{
    public interface ICommentService:IService<Comment>
    {
        Task<Comment> GetWithProductByIdAsync(int comId);
        Task<Comment> GetWithUserByIdAsync(int comId);
    }
}
