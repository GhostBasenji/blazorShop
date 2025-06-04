using shopData.Models;

namespace adminShop.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProducts();
        Task AddProduct(Product product);
        Task<Product?> GetProductById(int id);
        Task UpdateProduct(Product product);
        Task DeleteProduct(int id);
    }
}
