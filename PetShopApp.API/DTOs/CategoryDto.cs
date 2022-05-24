using System.ComponentModel.DataAnnotations;

namespace PetShopApp.API.DTOs
{
    public class CategoryDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Name { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }


    }
}
