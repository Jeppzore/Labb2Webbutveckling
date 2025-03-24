using Labb2Webbutveckling.Models;
using MongoDB.Driver;

namespace Labb2Webbutveckling.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly IMongoCollection<Order> _orders;

        public OrderRepository(IMongoDatabase database)
        {
            _orders = database.GetCollection<Order>("Orders");
        }

        public async Task<List<Order>> GetAllAsync() =>
            await _orders.Find(_ => true).ToListAsync();

        public async Task<Order> GetByIdAsync(string id) =>
            await _orders.Find(o => o.Id == id).FirstOrDefaultAsync();
        
        public async Task<List<Order>> GetByCustomerIdAsync(string customerId) =>
            await _orders.Find(o => o.CustomerId == customerId).ToListAsync();
        
        public async Task<Order> AddAsync(Order order)
        {
            await _orders.InsertOneAsync(order);
            return order;
        }
        
        public async Task<bool> UpdateStatusAsync(string id, string status)
        {
            var update = Builders<Order>.Update.Set(o => o.Status, status);
            var result = await _orders.UpdateOneAsync(o => o.Id == id, update);
            return result.ModifiedCount > 0;
        }  
    }
}