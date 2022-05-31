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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private PetShopDbContext PetShopDbContext { get => _db as PetShopDbContext; }
        public CommentRepository(PetShopDbContext db) : base(db)
        {
        }

        public async Task<Comment> GetWithProductByIdAsync(int comId)
        {

            var comment = _db.Comments.Include(s => s.Product).FirstOrDefaultAsync(s => s.Id == comId);
            return (await comment)!;
        }

        public async Task<Comment> GetWithUserByIdAsync(int comId)
        {
            var comment=_db.Comments.Include(s=>s.User).FirstOrDefaultAsync(s => s.Id == comId);
            return (await comment)!;
        }
    }
}
