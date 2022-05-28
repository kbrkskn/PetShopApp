using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController:ControllerBase
    {
        private IUserService _userService;
        private IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService= userService;
            _mapper=mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user=await _userService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<UserDto>>(user));
        }
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var user=await _userService.GetByIdAsync(id);
            return Ok(_mapper.Map<UserDto>(user));
        }

        [HttpPost]
        public async Task<IActionResult> Save (UserDto userDto)
        {
            var netUser = await _userService.AddAsync(_mapper.Map<User>(userDto));
            return Created(String.Empty,_mapper.Map<UserDto>(netUser));
        }

        [HttpPut]
        public IActionResult Update(UserDto userDto)
        {
            var user=_userService.Update(_mapper.Map<User>(userDto));
            return NoContent();
        }

        [HttpDelete]
        public IActionResult Remove(int id)
        {
            var user = _userService.GetByIdAsync(id).Result;
            _userService.Remove(user);
            return NoContent();
        }

        [HttpDelete("{name}")]
        public IActionResult RemoveByName(string name)
        {
            var user = _userService.Where(s => s.Name == name).Result;
            _userService.RemoveRange(user);
            return NoContent();
        }

        [HttpGet("{id:int}/orders")]
        public async Task<IActionResult> GetWithOrderByIdAsync(int id)
        {
            var user= await _userService.GetWithOrderByIdAsync(id);
            return Ok(_mapper.Map<UserWithOrdersDto>(user));
        }

        [HttpGet("{id:int}/comments")]
        public async Task<IActionResult> GetWithCommentByIdAsync(int id)
        {
            var user = await _userService.GetWithCommentByIdAsync(id);
            return Ok(_mapper.Map<UserWithCommentsDto>(user));
        }




    }
}
