using shopData.Models;

namespace shop.Services;

public interface IProductService
{
    Task<List<Product>> GetProductsAsync();
    Task<Product?> GetProductByIdAsync(int id);
}