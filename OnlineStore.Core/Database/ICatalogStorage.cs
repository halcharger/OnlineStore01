using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    public interface ICatalogStorage
    {
        Task<List<Product>> GetProductsByCategoryIdAsync(int id);
        Task<List<Category>> GetAllCategoriesAsync();
    }
}