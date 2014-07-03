using System.Linq;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    public class EntityFrameworkStorage : IStorage
    {
        public IQueryable<Product> Products { get; private set; }
    }
}