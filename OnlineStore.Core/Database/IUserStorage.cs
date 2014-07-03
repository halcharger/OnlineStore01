using System.Threading.Tasks;
using OnlineStore.Core.Database.Models;

namespace OnlineStore.Core.Database
{
    public interface IUserStorage
    {
        Task<User> GetUserAsync(string username, string hashedPassword);
    }
}