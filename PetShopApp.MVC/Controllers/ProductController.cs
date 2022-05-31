using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.Core.IntService;
using PetShopApp.MVC.DTOs;

namespace PetShopApp.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService,IMapper mapper)
        {
            _productService = productService;   
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var products=await _productService.GetAllAsync();
            return View(_mapper.Map<IEnumerable<ProductDto>>(products));
        }
    }
}
