using _3._Data.Context;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Users
{
    public class UserMySQLData : IUserData
    {
        private ChambeaPeContext _context;
        public UserMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }
        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.Where(u => u.IsActive).ToListAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            return await _context.Users.Where(u => u.IsActive).FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.Where(u => u.Email.Equals(email)).FirstOrDefaultAsync();
        }

        public async Task<User> GetByPhoneNumberAsync(string phoneNumber)
        {
            return await _context.Users.Where(u => u.PhoneNumber.Equals(phoneNumber)).FirstOrDefaultAsync();
        }

        public async Task<bool> CreateAsync(User user)
        {
            try
            {
                await _context.Users.AddAsync(user);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public async Task<bool> UpdateAsync(User user, int id)
        {
            try
            {
                var userToBeUpdated = await _context.Users.Where(u => u.Id == id && u.IsActive).FirstAsync();
                if(userToBeUpdated != null)
                {
                    user.DateUpdated = DateTime.Now;
                    _context.Users.Update(user);
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var userToBeDeleted = _context.Users.Where(u => u.IsActive && u.Id == id).First();

                userToBeDeleted.IsActive = false;
                userToBeDeleted.DateUpdated = DateTime.Now;

                _context.Users.Update(userToBeDeleted);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
