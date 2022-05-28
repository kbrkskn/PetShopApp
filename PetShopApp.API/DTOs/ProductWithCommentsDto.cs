namespace PetShopApp.API.DTOs
{
    public class ProductWithCommentsDto:ProductDto
    {
        public ICollection<CommentDto> Comments { get; set; }
    }
}
