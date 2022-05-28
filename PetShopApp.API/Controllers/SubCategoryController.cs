using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController:ControllerBase
    {
        private ISubCategoryService _scatService;
        private IMapper _mapper;

        public SubCategoryController(ISubCategoryService scatService, IMapper mapper)
        {
            _scatService = scatService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var subcat = await _scatService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<SubCategoryDto>>(subcat));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var scat = await _scatService.GetByIdAsync(id);
            return Ok(_mapper.Map<SubCategoryDto>(scat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(SubCategoryDto subcatDto)
        {
            var newscat = await _scatService.AddAsync(_mapper.Map<SubCategory>(subcatDto));
            return Created(String.Empty,_mapper.Map<SubCategoryDto>(newscat));

        }

        [HttpPut]
        public IActionResult Update(SubCategoryDto subcatDto)
        {
            _scatService.Update(_mapper.Map<SubCategory>(subcatDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var scat = _scatService.GetByIdAsync(id).Result;
            _scatService.Remove(scat);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult RemoveByName(string name)
        {
            var scat = _scatService.Where(s => s.Name == name).Result;
            _scatService.RemoveRange(scat);
            return NoContent();
        }

        [HttpGet("{id:int}/category")]
        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            var scat = await _scatService.GetWithCategoryByIdAsync(id);
            return Ok(_mapper.Map<SubCategoryWithCategoryDto>(scat));
        }
        [HttpGet("{id:int}/products")]//--DENEE
        public async Task<IActionResult> GetWithProductById(int id)
        {
            var scat = await _scatService.GetWithProductByIdAsync(id);
            return Ok(_mapper.Map<SubCategoryWithProductsDto>(scat));
        }


        [HttpGet("categoryall")]
        public async Task<IActionResult> GetAllWithCategory()
        {
            var scat = await _scatService.GetAllWithCategoryAsync();
            return Ok(_mapper.Map<IEnumerable<SubCategoryWithCategoryDto>>(scat));
        }

    }
}
