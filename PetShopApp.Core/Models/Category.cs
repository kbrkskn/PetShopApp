using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShopApp.Core.Models
{
    public class Category
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }=false;

        //Foreign Key
        public ICollection<SubCategory> SubCategories { get; set; }
        public ICollection<Product> Products { get; set; }  
    }
}
