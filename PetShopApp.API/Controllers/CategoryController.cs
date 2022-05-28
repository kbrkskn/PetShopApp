using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntRepository;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _catService;
        private IMapper _mapper;
        public CategoryController(ICategoryService catService, IMapper mapper)
        {
            _catService = catService;
            _mapper = mapper;

         }

        [HttpGet]
        public async Task<IActionResult> GetAll()//Bütün kategorileri listeler
        {
            var cat =await _catService.GetAllAsync();
            //return Ok(cat);
            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(cat));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)//Girilen id ye ait kategorileri listeler
        {
            var cat = await _catService.GetByIdAsync(id);
            return Ok(_mapper.Map<CategoryDto>(cat));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto catDto)//Yeni kategori ekleme
        {
            var newCat = await _catService.AddAsync(_mapper.Map<Category>(catDto));
            return Created(String.Empty, _mapper.Map<CategoryDto>(newCat));
        }

        [HttpPut]
        public IActionResult Update(CategoryDto catDto)
        {
            var cat = _catService.Update(_mapper.Map<Category>(catDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Remove(int id)//Bunu kullanmayabilirim çünkü pasif olacak silinmeyecek
        {
            var cat = _catService.GetByIdAsync(id).Result;
            _catService.Remove(cat);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult RemoveByName(string name)
        {
            var cat=_catService.Where(s=>s.Name== name).Result;
            _catService.RemoveRange(cat);
            return NoContent();
        }


        [HttpGet("{id:int}/subcategories")]
        public async Task<IActionResult> GetWithSubCategoryById(int id)
        {
            var cat = await _catService.GetWithSubCategoryByIdAsync(id);
            return Ok(_mapper.Map<CategoryWithSubCategoriesDto>(cat));
        }


    }

    
}
