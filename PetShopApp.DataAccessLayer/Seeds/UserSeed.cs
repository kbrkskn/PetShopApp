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
    public class UserSeed : IEntityTypeConfiguration<User>
    {

        //private readonly int[] _ids;
        private readonly Guid[] _guids;
        public UserSeed(Guid[] guids)
        {
            _guids = guids;
        }
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(
                new User { Id=_guids[21], Name="Kübra", LastName="Keskin", Email="kbrkskn@gmail.com", Password="123456",Phone="05362879963", IsActive=true, IsAdmin=false },
                new User { Id = _guids[22], Name = "Eymen", LastName = "Keskin", Email = "eymen@gmail.com", Password = "123456", Phone = "05362879963", IsActive = true, IsAdmin = false },
                new User { Id = _guids[23], Name = "Bahar", LastName = "Keskin", Email = "bhrkskn@gmail.com", Password = "123456", Phone = "05362879963", IsActive = true, IsAdmin = false }
                );
        }
    }
}
