using Microsoft.EntityFrameworkCore;
using shopData;
using shopData.Models;

namespace shop.Services;

public class ProductService : IProductService
{
    private readonly shopDbContext _context;

    public ProductService(shopDbContext context)
    {
        _context = context;
    }

    public async Task<List<Product>> GetProductsAsync()
    {
        return await _context.Products
            .Include(p => p.Category)
            .ToListAsync();
    }

    public async Task<Product?> GetProductByIdAsync(int id)
    {
        return await _context.Products
            .Include(p => p.Category)
            .FirstOrDefaultAsync(p => p.ProductId == id);
    }
}
