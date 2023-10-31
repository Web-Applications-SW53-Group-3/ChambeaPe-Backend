using _3._Data.Model;

namespace _2._Domain.Advertisements
{
    public interface IAdvertisementDomain
    {
        Task<bool> CreateAsync(Advertisement advertisement, int workerId);
        Task<bool> UpdateAsync(Advertisement advertisement, int id);
        Task<bool> DeleteAsync(int id);
    }
}