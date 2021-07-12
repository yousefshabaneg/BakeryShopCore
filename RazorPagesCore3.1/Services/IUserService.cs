using System.Collections.Generic;
using System.Threading.Tasks;
using WebRazor;

namespace RazorPagesCore3._1.Services
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync();
        Task<User> GetUserAsync(int id);

    }
}
