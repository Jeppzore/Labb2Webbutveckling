using Labb2Webbutveckling.Models;

namespace Labb2Webbutveckling.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
        Task<Product> GetByNameAsync(string name);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(string id);
        Task<bool> MarkProductAsUnavailable(string id);
        Task<bool> MarkProductAsAvailable(string id);

    }
}