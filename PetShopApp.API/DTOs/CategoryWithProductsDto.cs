namespace PetShopApp.API.DTOs
{
    public class CategoryWithProductsDto
    {
        public ICollection<ProductDto>? Products { get; set; }
    }
}
