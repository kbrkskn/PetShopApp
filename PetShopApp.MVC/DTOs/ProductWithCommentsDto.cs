namespace PetShopApp.MVC.DTOs
{
    public class ProductWithCommentsDto:ProductDto
    {
        public ICollection<CommentDto> Comments { get; set; }
    }
}
