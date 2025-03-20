using System.Linq.Expressions;
using System.Text.Json;
using Labb2Webbutveckling.Models;
using Labb2Webbutveckling.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

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

        [HttpGet("{email}")]
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
            Console.WriteLine("Received customer: " + JsonSerializer.Serialize(customer, new JsonSerializerOptions { WriteIndented = true }));

            if (string.IsNullOrWhiteSpace(customer.FirstName))
            {
                return BadRequest("First Name is required");
            }

            try
            { 
                await _repository.AddAsync(customer);

                // Fetch the newly created customer to ensure ID is correctly assigned
                var createdCustomer = await _repository.GetByEmailAsync(customer.Email!);
                if (createdCustomer == null)
                {
                    return StatusCode(500, "Customer was created but could not be retrieved");
                }

                return CreatedAtAction(nameof(GetByEmail), new { email = createdCustomer.Email }, createdCustomer);
            }
            // Return error message when customer tries to create an user with an already registered email
            catch (MongoWriteException ex) when (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
            {
                return Conflict("A customer with this email already exists.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
        

        [HttpPut("{email}")]
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