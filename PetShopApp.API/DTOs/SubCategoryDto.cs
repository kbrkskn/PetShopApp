using System.ComponentModel.DataAnnotations;

namespace PetShopApp.API.DTOs
{
    public class SubCategoryDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Name { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }

        //Foreign Key
        public Guid CategoryID { get; set; }
    }
}
