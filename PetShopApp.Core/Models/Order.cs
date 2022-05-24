using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Foreign Key

        public Guid UserID { get; set; }
        public virtual User User { get; set; }


        public Guid ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}
