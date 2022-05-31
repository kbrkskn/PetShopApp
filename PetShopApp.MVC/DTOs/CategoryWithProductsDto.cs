using PetShopApp.MVC.DTOs;

namespace PetShopApp.MVC.DTOs
{
    public class CategoryWithProductsDto
    {
        public ICollection<ProductDto>? Products { get; set; }
    }
}
