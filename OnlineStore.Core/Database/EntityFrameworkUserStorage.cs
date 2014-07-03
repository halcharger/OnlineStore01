using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    //See EntityFrameworkCatalogStorageclass comments
    public class EntityFrameworkUserStorage : IUserStorage
    {
        public IDbSet<User> Users { get; set; }

        public async Task<User> GetUserAsync(string username, string hashedPassword)
        {
            var users = await Users
                                .Where(u => u.Username == username && 
                                       u.HashedPassword == hashedPassword)
                                .ToListAsync();
            
            return users.FirstOrDefault();
        }
    }
}