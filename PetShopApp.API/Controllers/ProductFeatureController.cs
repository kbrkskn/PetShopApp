using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

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

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var prof = await _proFService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductFeatureDto>>(prof));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var prof = await _proFService.GetByIdAsync(id);  
            return Ok(_mapper.Map<ProductFeatureDto>(prof));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductFeatureDto proFDto)
        {
            var newProF = await _proFService.AddAsync(_mapper.Map<ProductFeature>(proFDto));
            return Created(String.Empty,_mapper.Map<ProductFeatureDto>(newProF));
        }

        [HttpPut]
        public IActionResult Update(ProductFeatureDto profDto)
        {
            _proFService.Update(_mapper.Map<ProductFeature>(profDto));
            return NoContent();
        }


        [HttpDelete]
        public IActionResult RemoveByProductId(int proId)//ProductId sine göre silinecek
        {
            var proF = _proFService.Where(s => s.ProductID == proId).Result;
            _proFService.RemoveRange(proF);
            return NoContent();
        }




        


        

    }
}
