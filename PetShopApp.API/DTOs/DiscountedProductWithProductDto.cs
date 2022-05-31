namespace PetShopApp.API.DTOs
{
    public class DiscountedProductWithProductDto:DiscountedProductDto
    {
        public ProductDto? Product { get; set; }
    }
}
