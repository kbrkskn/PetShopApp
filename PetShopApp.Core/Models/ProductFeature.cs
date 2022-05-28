using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class ProductFeature
    {
        public int Id { get; set; }
        public string Feature { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public int CreatedId { get; set; }

        //Foreign Key
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
        

    }
}
