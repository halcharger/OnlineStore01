using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    //I would rather expose EntityFramework IDbSet<T> to the rest of the application as opposed to using Repository pattern, 
    //but the Repository pattern was a requirement of the assignment
    public class EntityFrameworkCatalogStorage : DbContext, ICatalogStorage
    {
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Category> Categories { get; set; }

        public async Task<List<Product>> GetProductsByCategoryIdAsync(int id)
        {
            return await Products
                .Where(p => p.Category.Id == id)
                .Include(p => p.Category)
                .ToListAsync();
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
            return await Categories.ToListAsync();
        }
    }
}