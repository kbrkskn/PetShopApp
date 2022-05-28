using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController:ControllerBase
    {
        private ICommentService _comService;
        private IMapper _mapper;

        public CommentController(ICommentService comService, IMapper mapper)
        {
            _comService = comService;
            _mapper = mapper;
        }

        [HttpGet]//Buna gerek olmayabilir??
        public async Task<IActionResult> GetAll()
        {
            var com=await _comService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(com));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var com= await _comService.GetByIdAsync(id);
            return Ok(_mapper.Map<CommentDto>(com));
        }

        [HttpPost]
        public async Task<IActionResult> Save(CommentDto comDto)
        {
            var newCom = await _comService.AddAsync(_mapper.Map<Comment>(comDto));
            return Created(String.Empty,_mapper.Map<CommentDto>(newCom));
        }

        [HttpPut]
        public IActionResult Update(CommentDto comDto)
        {
            _comService.Update(_mapper.Map<Comment>(comDto));
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var com = _comService.GetByIdAsync(id).Result;
            _comService.Remove(com);
            return NoContent();
        }

        [HttpGet("{id:int}/product")]
        public async Task<IActionResult>GetWithProductById(int id)
        {
            var com = await _comService.GetWithProductByIdAsync(id);
            return Ok(_mapper.Map<CommentWithProductDto>(com));
        }


    }
}
