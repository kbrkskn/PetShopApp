namespace PetShopApp.API.DTOs
{
    public class SubCategoryWithCategoryDto:SubCategoryDto
    {
        public CategoryDto Category { get; set; }
    }
}
