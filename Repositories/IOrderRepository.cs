using Labb2Webbutveckling.Models;

namespace Labb2Webbutveckling.Repositories
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> GetByIdAsync(string id);
        Task<List<Order>> GetByCustomerIdAsync(string customerId);
        Task<Order> AddAsync(Order order);
        Task<bool> UpdateStatusAsync(string id, string status);
    }
}