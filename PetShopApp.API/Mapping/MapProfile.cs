using AutoMapper;
using PetShopApp.API.DTOs;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<Category, CategoryWithSubCategoriesDto>();
            CreateMap<CategoryWithSubCategoriesDto, Category>();

            CreateMap<Category, CategoryWithProductsDto>();
            CreateMap<CategoryWithProductsDto, Category>();



            CreateMap<SubCategory, SubCategoryDto>();
            CreateMap<SubCategoryDto, SubCategory>();

            CreateMap<SubCategory, SubCategoryWithCategoryDto>();
            CreateMap<SubCategoryWithCategoryDto, SubCategory>();

            CreateMap<SubCategory, SubCategoryWithProductsDto>();
            CreateMap<SubCategoryWithProductsDto, SubCategory>();



            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();

            CreateMap<Product, ProductWithSubCategoryDto>();
            CreateMap<ProductWithSubCategoryDto, Product>();

            CreateMap<Product, ProductWithCommentsDto>();
            CreateMap<ProductWithCommentsDto, Product>();

            CreateMap<ProductFeature, ProductFeatureDto>();
            CreateMap<ProductFeatureDto, ProductFeature>();




            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();

            CreateMap<Comment, CommentWithProductDto>();
            CreateMap<CommentWithProductDto, Comment>();



            CreateMap<Order, OrderDto>();
            CreateMap<OrderDto, Order>();

            
          

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<User, UserWithOrdersDto>();
            CreateMap<UserWithOrdersDto, User>();

            CreateMap<User, UserWithCommentsDto>();
            CreateMap<UserWithCommentsDto, User>();

        }
    }
}
