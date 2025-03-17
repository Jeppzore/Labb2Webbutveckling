using Labb2Webbutveckling.Models;
using Labb2Webbutveckling.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Labb2Webbutveckling.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerRepository _repository;
        
        // Constructor
        public CustomerController (ICustomerRepository customerRepository)
        {
            _repository = customerRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var customers = await _repository.GetAllAsync();
            return Ok(customers);
        }

        [HttpGet("{e-mail}")]
        public async Task<IActionResult> GetByEmail(string email)
        {
            var customer = await _repository.GetByEmailAsync(email);
            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Customer customer)
        {
            await _repository.AddAsync(customer);
            return CreatedAtAction(nameof(GetByEmail), new { id = customer.Id }, customer);
        }

        [HttpPut("{e-mail}")]
        public async Task<IActionResult> Update(string email, Customer updatedCustomer)
        {
            var existingCustomer = await _repository.GetByEmailAsync(email);
            if (existingCustomer == null)
            {
                return NotFound();
            }

            updatedCustomer.Email = email;
            await _repository.UpdateAsync(updatedCustomer);
            return NoContent();
        }
    }
}