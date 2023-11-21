using _3._Data.Model;

namespace _2._Domain.Postulations
{
    public interface IPostulationDomain
    {
        public Task<bool> CreateAsync(Postulation postulation);
        public Task<bool> DeleteAsync(int postulationId);
    }
}
