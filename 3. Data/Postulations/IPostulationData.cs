using _3._Data.Model;

namespace _3._Data.Postulations
{
    public interface IPostulationData
    {
        public Task<Postulation?> GetByIdAsync(int postulationId);
        public Task<List<Postulation>> GetAllByPostIdAsync(int postId);
        public Task<List<Postulation>> GetAllByWorkerIdAsync(int workerId);
        public Task<bool> CreateAsync(Postulation postulation);
        public Task<bool> DeleteAsync(int postulationId);
        public Task<bool> ExistsByWorkerIdAndPostIdAsync(int workerId, int postId);
    }
}