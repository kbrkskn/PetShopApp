namespace PetShopApp.API.DTOs
{
    public class CommentWithProductDto:CommentDto
    {
        public CategoryDto Category { get; set; }
    }
}
