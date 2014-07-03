using System.Linq;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    public interface IStorage
    {
        IQueryable<Product> Products { get; }
    }
}