using System.ComponentModel.DataAnnotations;

namespace PetShopApp.MVC.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} alanı zorunludur.")]
        public string? Text { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;


        public int UserID { get; set; }
        public int ProductID { get; set; }
    }
}
