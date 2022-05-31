namespace PetShopApp.API.DTOs
{
    public class ProductWithDiscountedProductsDto:ProductDto
    {
        public ICollection<DiscountedProductDto>? DiscountedProducts { get; set; }
    }
}
