namespace PetShopApp.MVC.DTOs
{
    public class ProductWithDiscountedProductsDto:ProductDto
    {
        public ICollection<DiscountedProductDto>? DiscountedProducts { get; set; }
    }
}
