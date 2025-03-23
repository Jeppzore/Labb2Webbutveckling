
using Microsoft.AspNetCore.Mvc;
using Labb2Webbutveckling.Models;
using Labb2Webbutveckling.Repositories;

namespace Labb2Webbutveckling.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrderController : ControllerBase
    {
        private readonly OrderRepository _repository;

        public OrderController(OrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var orders = await _repository.GetAllAsync();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrderById(string id)
        {
            var order = await _repository.GetByIdAsync(id);
            if (order == null)
            {
                return NotFound("Order not found");
            }
                
            return Ok(order);
        }

        [HttpGet("custuomer/{customerId}")]
        public async Task<ActionResult<List<Order>>> GetOrdersByCustomerId(string customerId)
        {
            var orders = await _repository.GetByCustomerIdAsync(customerId);
            return Ok(orders);
        }

        [HttpPost("{id}/status")]
        public async Task<ActionResult> UpdateOrderStatus(string id, [FromBody] string status)
        {
            var success = await _repository.UpdateStatusAsync(id, status);
            if (!success)
            {
                return NotFound("Order not found");
            }

            return NoContent();
        }

    }
}