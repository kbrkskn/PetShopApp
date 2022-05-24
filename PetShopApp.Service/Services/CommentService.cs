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
    public class CommentService : Service<Comment>, ICommentService
    {
        public CommentService(IUnitOfWork unit, IRepository<Comment> repo) : base(unit, repo)
        {
        }

        public async Task<Comment> GetWithProductByIdAsync(Guid comId)
        {
            return await _unit.Comment.GetWithProductByIdAsync(comId);
        }

        public async Task<Comment> GetWithUserByIdAsync(Guid comId)
        {
            return await _unit.Comment.GetWithUserByIdAsync(comId);
        }
    }
}
