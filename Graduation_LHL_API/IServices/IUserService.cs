using Graduation_LHL_API.Entity;

namespace Graduation_LHL_API.IServices
{
    public interface IUserService
    {
        Task<Boolean> LoginAsync(string username, string password);
        Task<Boolean> CreateAsync(User user,string password);

        Task<Boolean> UpdateAsync(User user,string password);

        Task<User> FindByEmailAsync(string username);

    }
}
