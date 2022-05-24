using System.ComponentModel.DataAnnotations;

namespace PetShopApp.API.DTOs
{
    public class CommentDto
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;


        public Guid UserID { get; set; }
        public Guid ProductID { get; set; }
    }
}
