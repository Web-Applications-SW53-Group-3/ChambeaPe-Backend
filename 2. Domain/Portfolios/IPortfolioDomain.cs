using _3._Data.Model;

namespace _2._Domain.Portfolios
{
    public interface IPortfolioDomain
    {
        Task<bool> CreateAsync(Portfolio portfolio, int workerId);
        Task<bool> UpdateAsync(Portfolio portfolio, int id);
        Task<bool> DeleteAsync(int id);
    }
}