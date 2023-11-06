using System.Threading.Tasks;
using Xunit;
using _2._Domain.Portfolios;
using _3._Data.Model;
using _2._Domain.Workers;
using NSubstitute;
using _2._Domain.Exceptions;
using _3._Data.Portfolios;

public class PortfolioDomainTests
{
    [Fact]
    public async Task CreateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var newPortfolio = new Portfolio();
        var workerId = 1;

        workerDomainMock.ExistsByWorkerId(workerId).Returns(true);
        portfolioDataMock.CreateAsync(newPortfolio).Returns(true);

        // Act
        var result = await portfolioDomain.CreateAsync(newPortfolio, workerId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task CreateAsync_InvalidWorker_ReturnsFalse()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var newPortfolio = new Portfolio();
        var workerId = 1;

        workerDomainMock.ExistsByWorkerId(workerId).Returns(false);

        // Act
        var result = await portfolioDomain.CreateAsync(newPortfolio, workerId);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public async Task UpdateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var portfolioToUpdate = new Portfolio();
        var portfolioId = 1;

        portfolioDataMock.GetByIdAsync(portfolioId).Returns(Task.FromResult(portfolioToUpdate));
        portfolioDataMock.UpdateAsync(portfolioToUpdate, portfolioId).Returns(true);

        // Act
        var result = await portfolioDomain.UpdateAsync(portfolioToUpdate, portfolioId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task UpdateAsync_InvalidPortfolio_ThrowsException()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var portfolioToUpdate = new Portfolio();
        var portfolioId = 1;

        portfolioDataMock.GetByIdAsync(portfolioId).Returns(Task.FromResult((Portfolio)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidPortfolioIDException>(async () =>
        {
            await portfolioDomain.UpdateAsync(portfolioToUpdate, portfolioId);
        });
    }

    [Fact]
    public async Task DeleteAsync_ValidPortfolio_ReturnsTrue()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var portfolioId = 1;

        portfolioDataMock.GetByIdAsync(portfolioId).Returns(Task.FromResult(new Portfolio()));
        portfolioDataMock.DeleteAsync(portfolioId).Returns(true);

        // Act
        var result = await portfolioDomain.DeleteAsync(portfolioId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task DeleteAsync_InvalidPortfolio_ThrowsException()
    {
        // Arrange
        var portfolioDataMock = Substitute.For<IPortfolioData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var portfolioDomain = new PortfolioDomain(portfolioDataMock, workerDomainMock);

        var portfolioId = 1;

        portfolioDataMock.GetByIdAsync(portfolioId).Returns(Task.FromResult((Portfolio)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidPortfolioIDException>(async () =>
        {
            await portfolioDomain.DeleteAsync(portfolioId);
        });
    }
}
