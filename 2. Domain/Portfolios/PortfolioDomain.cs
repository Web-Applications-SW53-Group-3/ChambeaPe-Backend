using _3._Data.Model;
using _3._Data.Portfolios;
using _2._Domain.Workers;
using _2._Domain.Exceptions;
using System.Threading.Tasks;

namespace _2._Domain.Portfolios
{
    public class PortfolioDomain : IPortfolioDomain
    {
        private readonly IPortfolioData _portfolioData;
        private readonly IWorkerDomain _workerDomain;

        public PortfolioDomain(IPortfolioData portfolioData, IWorkerDomain workerDomain)
        {
            _portfolioData = portfolioData;
            _workerDomain = workerDomain;
        }

        public async Task<bool> CreateAsync(Portfolio portfolio, int workerId)
        {
            var existsWorker = await _workerDomain.ExistsByWorkerId(workerId);
            bool existsPortfolioByUrl = await _portfolioData.ExistsByUrl(portfolio);

            if (!existsWorker)
            {
                return false;
            }

            if (existsPortfolioByUrl)
            {
                throw new DuplicatedPortfolioImageException("Duplicated portfolio image");
            }

            portfolio.WorkerId = workerId;
            return await _portfolioData.CreateAsync(portfolio);
        }

        public async Task<bool> UpdateAsync(Portfolio portfolio, int id)
        {
            Portfolio portfolioToBeUpdated = await _portfolioData.GetByIdAsync(id);
            bool existsPortfolioByUrl = await _portfolioData.ExistsByUrl(portfolio);

            if (portfolioToBeUpdated == null)
            {
                throw new InvalidPortfolioIDException();
            }

            if (existsPortfolioByUrl)
            {
                throw new DuplicatedPortfolioImageException("Duplicated portfolio image");
            }

            return await _portfolioData.UpdateAsync(portfolio, id);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            Portfolio portfolioToBeDeleted = await _portfolioData.GetByIdAsync(id);

            if (portfolioToBeDeleted == null)
            {
                throw new InvalidPortfolioIDException();
            }

            return await _portfolioData.DeleteAsync(id);
        }
    }
}