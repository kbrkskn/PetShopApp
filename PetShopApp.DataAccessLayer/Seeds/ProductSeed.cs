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
    public class ProductSeed : IEntityTypeConfiguration<Product>
    {

       // private readonly int[] _ids;
        private readonly Guid[] _guids;
        public ProductSeed(Guid[] guids)
        {
            _guids = guids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {Id= _guids[12], Name="Tahılsız Kedi Maması", Barcode="155855578", Brand="Nutri", CreatedDate=DateTime.Now, ExpirationDate=DateTime.Now, ModifiedDate=DateTime.Now, SubCategoryID=_guids[3], Price=250, Stock=10, }
                );
            builder.HasData(
               new Product { Id = _guids[13], Name = "Tahılsız Köpek Maması", Barcode = "155855579", Brand = "Nutri", CreatedDate = DateTime.Now, ExpirationDate = DateTime.Now, ModifiedDate = DateTime.Now, SubCategoryID = _guids[6], Price = 150, Stock = 10, }
               );
            builder.HasData(
               new Product { Id = _guids[14], Name = "Tahılsız Kuş Yemi", Barcode = "155955579", Brand = "Nutri", CreatedDate = DateTime.Now, ExpirationDate = DateTime.Now, ModifiedDate = DateTime.Now, SubCategoryID = _guids[9], Price = 100, Stock = 10, }
               );
        }
    }
}
