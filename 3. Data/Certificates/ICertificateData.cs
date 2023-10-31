using _3._Data.Model;

namespace _3._Data.Certificates
{
    public interface ICertificateData
    {
        Task<Certificate> GetByIdAsync(int id);
        Task<List<Certificate>> GetAllAsync();
        Task<bool> CreateAsync(Certificate certificate);
        Task<bool> UpdateAsync(Certificate certificate, int id);
        Task<bool> DeleteAsync(int id);
    }
}