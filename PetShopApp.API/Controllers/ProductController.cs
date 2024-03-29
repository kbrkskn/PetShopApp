﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    //[ValidationFilter]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController:ControllerBase
    {
        private IProductService _proService;
        private IMapper _mapper;

        public ProductController(IProductService proService, IMapper mapper)
        {
            _proService = proService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var pro=await _proService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<ProductDto>>(pro));
        }


       [HttpGet("{id:int}")]
       public async Task<IActionResult> GetById(int id)
        {
            var pro =await _proService.GetByIdAsync(id);
            return Ok(_mapper.Map<ProductDto>(pro));
        }

        [HttpPost]
        public async Task<IActionResult> Save(ProductDto proDto)
        {
            var newPro = await _proService.AddAsync(_mapper.Map<Product>(proDto));
            return Created(String.Empty,_mapper.Map<ProductDto>(newPro));
        }

        [HttpPut]
        public IActionResult Update(ProductDto proDto)
        {
            _proService.Update(_mapper.Map<Product>(proDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var pro = _proService.GetByIdAsync(id).Result;
            _proService.Remove(pro);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult RemoveByName(string name)
        {
            var pro = _proService.Where(s => s.Name == name).Result;
            _proService.RemoveRange(pro);
            return NoContent();
        }

        [HttpGet("{id:int}/subcategory")]
        public async Task<IActionResult> GetWithSubCategoryById(int id)
        {
            var pro = await _proService.GetWithSubCategoryByIdAsync(id);
            return Ok(_mapper.Map<ProductWithSubCategoryDto>(pro));
        }

        [HttpGet("subcategoryall")]
        public async Task<IActionResult> GetAllWithSubCategory()
        {
            var pro = await _proService.GetAllWithSubCategoryAsync();
            return Ok(_mapper.Map<IEnumerable<ProductWithSubCategoryDto>>(pro));
        }

        [HttpGet("{id:int}/comments")]
        public async Task<IActionResult> GetWithCommmentById(int id)
        {
            var pro = await _proService.GetWithCommentByIdAsync(id);
            return Ok(_mapper.Map<ProductWithCommentsDto>(pro));
        }

        [HttpGet("{id:int}/category")]
        public async Task<IActionResult> GetWithCategoryById(int id)
        {
            var pro = await _proService.GetWithCategoryByIdAsync(id);
            return Ok(_mapper.Map<ProductWithCategoryDto>(pro));
        }

        [HttpGet("categoryall")]
        public async Task<IActionResult> GetAllWithCategory()
        {
            var pro = await _proService.GetAllWithCategoryAsync();
            return Ok(_mapper.Map<IEnumerable<ProductWithCategoryDto>>(pro));
        }


    }
}
