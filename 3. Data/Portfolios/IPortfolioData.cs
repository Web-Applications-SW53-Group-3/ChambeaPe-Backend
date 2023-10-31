using _3._Data.Model;

namespace _3._Data.Portfolios
{
    public interface IPortfolioData
    {
        Task<Portfolio> GetByIdAsync(int id);
        Task<List<Portfolio>> GetAllAsync();
        Task<bool> CreateAsync(Portfolio portfolio);
        Task<bool> UpdateAsync(Portfolio portfolio, int id);
        Task<bool> DeleteAsync(int id);
    }
}