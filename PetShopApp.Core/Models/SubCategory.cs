using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }    
        public bool IsDeleted { get; set; }=false;
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //Foreign Key
        public int CategoryID { get; set; }
        public virtual Category? Category { get; set; }


        public ICollection<Product>? Products { get; set; }
    }
}
