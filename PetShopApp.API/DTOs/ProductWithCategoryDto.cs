﻿namespace PetShopApp.API.DTOs
{
    public class ProductWithCategoryDto:ProductDto
    {
        public CategoryDto? Category { get; set; }
    }
}
