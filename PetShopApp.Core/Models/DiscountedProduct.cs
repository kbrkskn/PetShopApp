using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class DiscountedProduct
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedPrice { get; set; }
        public int Percent { get; set; }
        public bool IsActive { get; set; }

        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}
