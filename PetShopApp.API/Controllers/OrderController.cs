using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PetShopApp.API.DTOs;
using PetShopApp.Core.IntService;
using PetShopApp.Core.Models;

namespace PetShopApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController:ControllerBase
    {
        private IOrderService _orderService;
        private IMapper _mapper;

        public OrderController(IOrderService orderService, IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var order=await _orderService.GetAllAsync();
            return Ok(_mapper.Map<IEnumerable<OrderDto>>(order));
        }

        [HttpGet("{id:int}")]

        public async Task<IActionResult> GetById(int id)
        {
            var order=await _orderService.GetByIdAsync(id);
            return Ok(_mapper.Map<OrderDto>(order));
        }

        [HttpPost]
        public async Task<IActionResult> Save(OrderDto orderDto)
        {
            var newOrder = await _orderService.AddAsync(_mapper.Map<Order>(orderDto));
            return Created(String.Empty,_mapper.Map<OrderDto>(newOrder));
        }


        [HttpPut]
        public IActionResult Update(OrderDto orderDto)
        {
            _orderService.Update(_mapper.Map<Order>(orderDto));
            return NoContent();
        }


        [HttpDelete("{id:int}")]
        public IActionResult Remove(int id)
        {
            var order = _orderService.GetByIdAsync(id).Result;
            _orderService.Remove(order);
            return NoContent();

        }
        //productId ve userıd göre silme işlemleri??


    }
}
