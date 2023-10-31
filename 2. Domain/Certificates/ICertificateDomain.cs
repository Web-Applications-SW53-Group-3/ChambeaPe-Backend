using _3._Data.Model;

namespace _2._Domain.Certificates
{
    public interface ICertificateDomain
    {
        Task<bool> CreateAsync(Certificate certificate, int workerId);
        Task<bool> UpdateAsync(Certificate certificate, int id);
        Task<bool> DeleteAsync(int id);
    }
}