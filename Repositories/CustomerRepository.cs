
using Labb2Webbutveckling.Models;
using MongoDB.Driver;

namespace Labb2Webbutveckling.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly IMongoCollection<Customer> _customers;

        public CustomerRepository(IMongoDatabase database)
        {
            _customers = database.GetCollection<Customer>("Customers");
        }

        public async Task AddAsync(Customer customer)
        {
            await _customers.InsertOneAsync(customer);
        }

        public async Task<List<Customer>> GetAllAsync()
        {
            return await _customers.Find(_ => true).ToListAsync();
        }

        public async Task<Customer> GetByEmailAsync(string email)
        {
            return await _customers.Find(c => c.Email == email).FirstOrDefaultAsync();
        }

        public async Task UpdateAsync(Customer customer)
        {
            await _customers.ReplaceOneAsync(c => c.Email == customer.Email, customer);
        }

        public async Task EnsureIndexesAsync()
        {
            var indexKeys = Builders<Customer>.IndexKeys.Ascending(c => c.Email);
            var indexOptions = new CreateIndexOptions { Unique = true };
            var indexModel = new CreateIndexModel<Customer>(indexKeys, indexOptions);

            await _customers.Indexes.CreateOneAsync(indexModel);
        }
    }
}