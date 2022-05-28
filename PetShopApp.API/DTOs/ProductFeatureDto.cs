using System.ComponentModel.DataAnnotations;

namespace PetShopApp.API.DTOs
{
    public class ProductFeatureDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Feature { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        //public int CreatedId { get; set; }

        //Foreign Key
        public int ProductID { get; set; }

    }
}
