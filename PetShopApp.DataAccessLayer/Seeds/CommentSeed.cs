using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PetShopApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.DataAccessLayer.Seeds
{
    public class CommentSeed : IEntityTypeConfiguration<Comment>
    {
        //private readonly int[] _ids;
        private readonly Guid[] _guids;
        public CommentSeed(Guid[] guids)
        {
            _guids = guids;
        }
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { Id = Guid.NewGuid(), Text = "Yorummmmm", UserID = _guids[21], CreatedDate=DateTime.Now,ModifiedDate=DateTime.Now, IsDeleted=false, ProductID=_guids[13] },
                new Comment { Id = Guid.NewGuid(), Text = "Yorummmmm", UserID = _guids[21], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false, ProductID = _guids[12] },
                 new Comment { Id = Guid.NewGuid(), Text = "Yorummmmm", UserID = _guids[22], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false, ProductID = _guids[12] }
                );
        }
}
}
