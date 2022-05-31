namespace PetShopApp.MVC.DTOs
{
    public class CommentWithProductDto:CommentDto
    {
        public CategoryDto Category { get; set; }
    }
}
