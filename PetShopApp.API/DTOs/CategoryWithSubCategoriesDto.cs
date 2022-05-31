namespace PetShopApp.API.DTOs
{
    public class CategoryWithSubCategoriesDto:CategoryDto
    {
        public ICollection<SubCategoryDto>? SubCategories { get; set; }
    }
}
