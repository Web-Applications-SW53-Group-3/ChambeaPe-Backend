using _2._Domain.Portfolios;
using _2._Domain.Workers;
using _3._Data.Employers;
using _3._Data.Model;
using _3._Data.Portfolios;
using _3._Data.Posts;
using NSubstitute;

namespace _2._Domain.Tests.PostsTests;

public class PostDomainTest
{
    //happy path Create Async
    [Fact]
    public async Task CreateAsync_Successful()
    {
        // Arrange
        var portfolio = new Portfolio();
        var workerId = 1;

        // Crear simulaciones (mocks)
        var workerDomain = Substitute.For<IWorkerDomain>();
        var portfolioData = Substitute.For<IPortfolioData>();

        var portfolioDomain = new PortfolioDomain(portfolioData, workerDomain);

        workerDomain.ExistsByWorkerId(workerId).Returns(true);
        portfolioData.CreateAsync(portfolio).Returns(true);

        // Act
        var result = await portfolioDomain.CreateAsync(portfolio, workerId);

        // Assert
        Assert.True(result);
    }
    
    

    
}