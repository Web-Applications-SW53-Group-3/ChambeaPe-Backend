using _3._Data.Model;

namespace _3._Data.Users
{
    
    public interface IUserData
    {
        public Task<User> GetByIdAsync(int id);
        public Task<User> GetByEmailAsync(string email);
        public Task<User> GetByPhoneNumberAsync(string phoneNumber);
        public Task<List<User>> GetAllAsync();
        public Task<bool> CreateAsync(User user);
        public Task<bool> UpdateAsync(User user, int id);
        public Task<bool> DeleteAsync(int id);
    }
}
