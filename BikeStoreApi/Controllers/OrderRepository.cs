using Microsoft.AspNetCore.Mvc;
using BikeStore.Models;
using BikeStoreApi.Repositories;
using BikeStoreApi.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BikeStoreApi.Controllers
{
    [Route("api/Order")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork, IOrderRepository orderRepository)
        {
            _unitOfWork = unitOfWork;
            _orderRepository = orderRepository;
        }
        
        [HttpGet("GetAll")]
        public async Task<ActionResult<IEnumerable<Order>>> GetAll()
        {
            var orders = await _orderRepository.GetAll();
            return Ok(orders);
        }
        
        [HttpGet("Get/{id}")]
        public async Task<ActionResult<Order>> Get(string id)
        {
            var order = await _orderRepository.GetById(id);
            if (order == null)
            {
                return BadRequest();
            }
            return Ok(order);
        }
        
        [HttpPost("Create")]
        public async Task<ActionResult<Order>> Create(Order order)
        {
            _orderRepository.Create(order);
            await _unitOfWork.Commit();
            var newOrder = await _orderRepository.GetById(order.Id);
            if (newOrder == null)
            {
                return BadRequest();
            }
            return Ok(newOrder);
        }
        
        [HttpPut("Edit")]
        public async Task<ActionResult<Order>> UpdateOrderAsync(Order order)
        {
            var oldOrderCheck = await _orderRepository.GetById(order.Id);
            if (oldOrderCheck == null)
                return NotFound();
            _orderRepository.Update(order, order.Id);
            await _unitOfWork.Commit();
            return Ok(order);
        }
        
        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var orderToDelete = await _orderRepository.GetById(id);
            if (orderToDelete == null)
                return BadRequest();
            _orderRepository.Delete(id);
            await _unitOfWork.Commit();
            var deletedOrder = await _orderRepository.GetById(id);
            if (deletedOrder == null)
            {
                return Ok();
            }
            return BadRequest();
        }
    }   
}