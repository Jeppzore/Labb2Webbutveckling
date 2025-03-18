using Labb2Webbutveckling.Models;
using MongoDB.Driver;

namespace Labb2Webbutveckling.Repositories
{
    // Repository Pattern
    // Controllers only communicates with the repository instead of directly with database.
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<Product> _products;

        public ProductRepository(IMongoDatabase database)
        {
            _products = database.GetCollection<Product>("Products");
        }

        public async Task AddAsync(Product product)
        {
            await _products.InsertOneAsync(product);
        }

        public async Task DeleteAsync(string id)
        {
            await _products.DeleteOneAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _products.Find(_ => true).ToListAsync();
        }

        public async Task<Product> GetByIdAsync(string id)
        {
            return await _products.Find(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Product product)
        {
            await _products.ReplaceOneAsync(p => p.Id == product.Id, product);
        }

        public async Task<bool> MarkProductAsUnavailable(string id)
        {
            var filter = Builders<Product>.Filter.Eq(p => p.Id, id);
            var update = Builders<Product>.Update.Set(p => p.Status, ProductStatus.Unavailable);

            var result = await _products.UpdateOneAsync(filter, update);
            return result.ModifiedCount > 0;
        }

        public async Task<bool> MarkProductAsAvailable(string id)
        {
            var filter = Builders<Product>.Filter.Eq(p => p.Id, id);
            var update = Builders<Product>.Update.Set(p => p.Status, ProductStatus.Available);     
        
            var result = await _products.UpdateOneAsync(filter, update);
            return result.ModifiedCount > 0;
        }
    }
}