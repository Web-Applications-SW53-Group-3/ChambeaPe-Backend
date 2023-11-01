using _3._Data.Model;

namespace _3._Data.Advertisements
{
    public interface IAdvertisementData
    {
        Task<Advertisement> GetByIdAsync(int id);
        Task<List<Advertisement>> GetAllAsync();
        Task<bool> CreateAsync(Advertisement advertisement);
        Task<bool> UpdateAsync(Advertisement advertisement, int id);
        Task<bool> DeleteAsync(int id);
    }
}