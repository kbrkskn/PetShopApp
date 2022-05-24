namespace PetShopApp.API.DTOs
{
    public class SubCategoryWithProductsDto:SubCategoryDto
    {
        public ICollection<ProductDto> Products { get; set; }
    }
}
