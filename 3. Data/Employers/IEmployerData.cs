using _3._Data.Model;

namespace _3._Data.Employers
{
    public interface IEmployerData
    {
        public Task<Employer> GetByIdAsync(int id);
        public Task<List<Employer>> GetAllAsync();
        public Task<bool> CreateAsync(Employer employer);
        public Task<bool> UpdateAsync(Employer employer, int id);
        public Task<bool> DeleteAsync(int id);
    }
}
