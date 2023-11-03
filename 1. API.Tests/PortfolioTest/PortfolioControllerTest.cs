using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Portfolios;
using _3._Data.Model;
using _3._Data.Portfolios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace _1._API.Tests.PortfolioTest
{
    public class PortfolioControllerTest
    {
        private readonly PortfolioController _controller;
        private readonly Mock<IPortfolioData> _mockPortfolioData;
        private readonly Mock<IPortfolioDomain> _mockPortfolioDomain;
        private readonly Mock<IMapper> _mockMapper;

        public PortfolioControllerTest()
        {
            _mockPortfolioData = new Mock<IPortfolioData>();
            _mockPortfolioDomain = new Mock<IPortfolioDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<PortfolioController>> mockLogger = new();

            _controller = new PortfolioController(
                _mockPortfolioData.Object,
                _mockPortfolioDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var portfolioList = new List<Portfolio>();
            _mockPortfolioData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(portfolioList);
            var portfolioResponseList = new List<PortfolioResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Portfolio>, List<PortfolioResponse>>(portfolioList))
                .Returns(portfolioResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<PortfolioResponse>>(okResult.Value);
            Assert.Equal(portfolioResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidPortfolioID_ReturnsOkResult()
        {
            // Arrange
            var portfolio = new Portfolio();
            _mockPortfolioData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(portfolio);
            var portfolioResponse = new PortfolioResponse();
            _mockMapper.Setup(mapper => mapper.Map<Portfolio, PortfolioResponse>(portfolio))
                .Returns(portfolioResponse);

            // Act
            var result = await _controller.GetAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<PortfolioResponse>(okResult.Value);
            Assert.Equal(portfolioResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidPortfolioID_ReturnsNotFound()
        {
            // Arrange
            var portfolio = new Portfolio();
            _mockPortfolioData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(portfolio);
            var portfolioResponse = new PortfolioResponse();
            _mockMapper.Setup(mapper => mapper.Map<Portfolio, PortfolioResponse>(portfolio))
                .Returns(portfolioResponse);

            // Act
            var result = await _controller.GetAsync(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsCreatedAtRouteResult()
        {
            // Arrange
            var portfolioRequest = new PortfolioRequest();

            _mockPortfolioDomain.Setup(domain => domain.CreateAsync(It.IsAny<Portfolio>(), 1)).ReturnsAsync(true);
            var portfolio = new Portfolio();
            _mockMapper.Setup(mapper => mapper.Map<PortfolioRequest, Portfolio>(It.IsAny<PortfolioRequest>()))
                .Returns(portfolio);

            // Act
            var result = await _controller.PostAsync(portfolioRequest, 1);

            // Assert
            Assert.IsType<CreatedAtRouteResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithInvalidWorkerID_ReturnsBadRequest()
        {
            // Arrange
            var portfolioRequest = new PortfolioRequest();

            _mockPortfolioDomain.Setup(domain => domain.CreateAsync(It.IsAny<Portfolio>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PostAsync(portfolioRequest, 1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var portfolioRequest = new PortfolioRequest();
            _mockPortfolioDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Portfolio>(), 1)).ReturnsAsync(true);

            // Act
            var result = await _controller.PutAsync(1, portfolioRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithInvalidPortfolioID_ReturnsNotFound()
        {
            // Arrange
            var portfolioRequest = new PortfolioRequest();

            _mockPortfolioDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Portfolio>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PutAsync(1, portfolioRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var portfolio = new Portfolio();

            _mockPortfolioDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(true);
            var portfolioResponse = new PortfolioResponse();
            _mockMapper.Setup(mapper => mapper.Map<Portfolio, PortfolioResponse>(portfolio))
                .Returns(portfolioResponse);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidPortfolioID_ReturnsNotFound()
        {
            // Arrange
            _mockPortfolioDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}
