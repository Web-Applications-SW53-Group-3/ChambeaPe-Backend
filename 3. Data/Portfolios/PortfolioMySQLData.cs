using _3._Data.Model;
using _3._Data.Context;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Portfolios
{
    public class PortfolioMySQLData : IPortfolioData
    {
        private ChambeaPeContext _context;

        public PortfolioMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Portfolio>> GetAllAsync()
        {
            return await _context.Portfolios.Where(p => p.IsActive).ToListAsync();
        }

        public async Task<Portfolio> GetByIdAsync(int id)
        {
            return await _context.Portfolios.Where(p => p.IsActive).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<bool> CreateAsync(Portfolio portfolio)
        {
            try
            {
                await _context.Portfolios.AddAsync(portfolio);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> UpdateAsync(Portfolio portfolio, int id)
        {
            try
            {
                var portfolioToBeUpdated = await _context.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
                if (portfolioToBeUpdated != null)
                {
                    portfolioToBeUpdated.ImageUrl = portfolio.ImageUrl;
                    portfolioToBeUpdated.DateUpdated = DateTime.Now;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var portfolioToBeDeleted = await _context.Portfolios.FirstOrDefaultAsync(p => p.Id == id);
                if (portfolioToBeDeleted != null)
                {
                    portfolioToBeDeleted.IsActive = false;
                    await _context.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public async Task<bool> ExistsByUrl(Portfolio portfolioToBeChecked)
        {
            Portfolio? portfolio = await _context.Portfolios
                .Where(p => p.IsActive && p.ImageUrl== portfolioToBeChecked.ImageUrl)
                .FirstOrDefaultAsync();
            if(portfolio != null)
            {
                return true;
            }
            return false;
        }
    }

}
