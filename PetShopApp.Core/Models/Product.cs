using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public decimal Price { get; set; }
        public decimal SalePrice { get; set; }
        public int Sale { get; set; }
        public int Stock { get; set; } = 0;
        public string Brand { get; set; }
        public string Img { get; set; }
        public string Barcode { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsSale { get; set; }=false;
        public bool IsDeleted { get; set; } = false;
        //public int CreatedId { get; set; }

        //Foreign Key

        public ICollection<Comment> Comments { get; set; }
        public int SubCategoryID { get; set; }
        public virtual SubCategory SubCategory { get; set; }

        public ICollection<ProductFeature> ProductFeatures { get; set; }

        public ICollection<Order> Orders { get; set; }




    }
}
