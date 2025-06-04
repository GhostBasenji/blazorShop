using shopData.Models;

namespace adminShop.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategories();
        Task AddCategory(Category category);
        Task DeleteCategory(int id);
        Task<Category?> GetCategoryById(int id);
        Task UpdateCategory(Category category);
    }
}
