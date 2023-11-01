using _3._Data.Model;

namespace _2._Domain.Employers
{
    public interface IEmployerDomain
    {
        public Task<bool> CreateAsync(Employer employer, User user);
        public Task<bool> UpdateAsync(Employer employer, User user, int id);
        public Task<bool> DeleteAsync(int id);
    }
}
