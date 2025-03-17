using Labb2Webbutveckling.Models;


namespace Labb2Webbutveckling.Repositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAllAsync();
        Task<Customer> GetByEmailAsync(string email);
        Task UpdateAsync(Customer customer);
        Task AddAsync(Customer customer);      
    }
}