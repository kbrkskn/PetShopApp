using System.ComponentModel.DataAnnotations;

namespace PetShopApp.API.DTOs
{
    public class UserDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Phone { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }


    }
}
