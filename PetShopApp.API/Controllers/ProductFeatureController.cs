using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductFeatureController:ControllerBase
    {
        private IProductFeatureService _proFService;
        private IMapper _mapper;

        public ProductFeatureController(IProductFeatureService proFService, IMapper mapper)
        {
            _proFService = proFService;
            _mapper = mapper;
        }

        public async Task<IActionResult> GetAll()
        {
            var prof = await _proFService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductFeatureDto>>(prof));
        }

        

    }
}
