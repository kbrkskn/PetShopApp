using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrdersNo { get; set; }
        public DateTime? CreatedDate { get; set; }

        //Foreign Key

        public int UserID { get; set; }
        public virtual User User { get; set; }


        public int ProductID { get; set; }
        public virtual Product Product { get; set; }

    }
}
