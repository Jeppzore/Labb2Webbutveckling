using Labb2Webbutveckling.Models;
using Labb2Webbutveckling.Repositories;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Labb2Webbutveckling.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _repository.GetAllAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var product = await _repository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            await _repository.AddAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id}, product);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(string id, Product updatedProduct)
        {
            var existingProduct = await _repository.GetByIdAsync(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            updatedProduct.Id = id;
            await _repository.UpdateAsync(updatedProduct);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var existingProduct = await _repository.GetByIdAsync(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync(id);
            return NoContent();
        }
    }
}