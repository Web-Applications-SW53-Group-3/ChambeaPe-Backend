using _3._Data.Model;

namespace _2._Domain.Users
{
    public interface IUserDomain
    {
        Task<bool> CreateAsync(User user, string userRole);
        Task<bool> UpdateAsync(User user, int id, string userRole);
        Task<bool> DeleteAsync(int id);
    }
}
