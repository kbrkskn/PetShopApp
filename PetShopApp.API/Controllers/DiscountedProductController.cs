using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class DiscountedProductController : Controller
    {
        private IDiscountedProductService _disProService;
        private IMapper _mapper;

        public DiscountedProductController(IDiscountedProductService disProService, IMapper mapper)
        {
            _disProService = disProService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var dispro = await _disProService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<DiscountedProductDto>>(dispro));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var dispro = await _disProService.GetByIdAsync(id);
            return Ok(_mapper.Map<DiscountedProductDto>(dispro));
        }

        [HttpPost]
        public async Task<IActionResult> Save(DiscountedProductDto disProDto)
        {
            var newDisPro = await _disProService.AddAsync(_mapper.Map<DiscountedProduct>(disProDto));
            return Created(String.Empty, _mapper.Map<DiscountedProductDto>(newDisPro));
        }

        [HttpPut]
        public IActionResult Update(DiscountedProductDto disProDto)
        {
            _disProService.Update(_mapper.Map<DiscountedProduct>(disProDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var disPro=_disProService.GetByIdAsync(id).Result;
            _disProService.Remove(disPro);
            return NoContent();
        }

        [HttpGet("{id:int}/product")]
        public async Task<IActionResult> GetWithProductById(int id)
        {
            var disPro = await _disProService.GetWithProductByIdAsync(id);
            return Ok(_mapper.Map<DiscountedProductWithProductDto>(disPro));
        }
    }
}
