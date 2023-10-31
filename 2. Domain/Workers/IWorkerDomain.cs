using _3._Data.Model;

namespace _2._Domain.Workers
{
    public interface IWorkerDomain
    {
        public Task<bool> ExistsByWorkerId(int id);
        public Task<bool> CreateAsync(Worker worker, User user);
        public Task<bool> UpdateAsync(Worker worker, User user, int id);
        public Task<bool> DeleteAsync(int id);
    }
}
