namespace PetShopApp.MVC.DTOs
{
    public class DiscountedProductWithProductDto:DiscountedProductDto
    {
        public ProductDto? Product { get; set; }
    }
}
