using _3._Data.Model;

namespace _3._Data.Workers
{
    public interface IWorkerData
    {
        public Task<Worker?> ExistsByIdAsync(int id);
        public Task<Worker?> GetByIdAsync(int id);
        public Task<List<Worker>> GetAllAsync();
        public Task<bool> CreateAsync(Worker worker);
        public Task<bool> UpdateAsync(Worker worker, int id);
        public Task<bool> DeleteAsync(int id);
    }
}
