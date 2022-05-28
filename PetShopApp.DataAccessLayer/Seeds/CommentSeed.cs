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
        private readonly int[] _ids;
        public CommentSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasData(
                new Comment { Id = 100, Text = "Yorummmmm", UserID = _ids[21], CreatedDate=DateTime.Now,ModifiedDate=DateTime.Now, IsDeleted=false, ProductID=_ids[13] },
                new Comment { Id = 101, Text = "Yorummmmm", UserID = _ids[21], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false, ProductID = _ids[12] },
                 new Comment { Id = 102, Text = "Yorummmmm", UserID = _ids[22], CreatedDate = DateTime.Now, ModifiedDate = DateTime.Now, IsDeleted = false, ProductID = _ids[12] }
                );
        }
}
}
