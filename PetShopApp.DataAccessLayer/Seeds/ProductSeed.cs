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
        private readonly int[] _ids;
        public ProductSeed(int[] ids)
        {
            _ids = ids;
        }
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product {Id= _ids[12], Name="Tahılsız Kedi Maması", Barcode="155855578", Brand="Nutri", CreatedDate=DateTime.Now, ExpirationDate=DateTime.Now, ModifiedDate=DateTime.Now, SubCategoryID=_ids[3], Price=250,Sale=50,SalePrice=125, Stock=10, Img="aa",IsSale=true,}
                );
            builder.HasData(
               new Product { Id = _ids[13], Name = "Tahılsız Köpek Maması", Barcode = "155855579", Brand = "Nutri", CreatedDate = DateTime.Now, ExpirationDate = DateTime.Now, ModifiedDate = DateTime.Now, SubCategoryID = _ids[6], Price = 150, Stock = 10, Img = "aa", }
               );
            builder.HasData(
               new Product { Id = _ids[14], Name = "Tahılsız Kuş Yemi", Barcode = "155955579", Brand = "Nutri", CreatedDate = DateTime.Now, ExpirationDate = DateTime.Now, ModifiedDate = DateTime.Now, SubCategoryID = _ids[9], Price = 100, Stock = 10, Img = "aa", }
               );
        }
    }
}
