namespace PetShopApp.MVC.DTOs
{
    public class CategoryWithSubCategoriesDto:CategoryDto
    {
        public ICollection<SubCategoryDto>? SubCategories { get; set; }
    }
}
