
using Labb2Webbutveckling.Models;
using MongoDB.Driver;

namespace Labb2Webbutveckling.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public Task AddAsync(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task<List<Customer>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetByEmailAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}