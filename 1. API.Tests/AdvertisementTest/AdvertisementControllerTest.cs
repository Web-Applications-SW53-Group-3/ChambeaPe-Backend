using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _3._Data.Advertisements;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using _2._Domain.Advertisements;
using _3._Data.Model;
using Microsoft.Extensions.Logging;
using Moq;

namespace _1._API.Tests.AdvertisementTest
{
    public class AdvertisementControllerTest
    {
        
        private readonly AdvertisementController _controller;
        private readonly Mock<IAdvertisementData> _mockAdvertisementData;
        private readonly Mock<IAdvertisementDomain> _mockAdvertisementDomain;
        private readonly Mock<IMapper> _mockMapper;

        public AdvertisementControllerTest()
        {
            _mockAdvertisementData = new Mock<IAdvertisementData>();
            _mockAdvertisementDomain= new Mock<IAdvertisementDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<AdvertisementController>> mockLogger = new();

            _controller = new AdvertisementController(
                _mockAdvertisementData.Object,
                _mockAdvertisementDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var advertisementList = new List<Advertisement>();
            _mockAdvertisementData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(advertisementList);
            var advertisementResponseList = new List<AdvertisementResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Advertisement>, List<AdvertisementResponse>>(advertisementList))
                .Returns(advertisementResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<AdvertisementResponse>>(okResult.Value);
            Assert.Equal(advertisementResponseList, model);
        }
        
        [Fact]
        public async Task GetAsync_WithValidAdvertisementID_ReturnsOkResult()
        {
            // Arrange
            var advertisement = new Advertisement();
            _mockAdvertisementData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(advertisement);
            var advertisementResponse = new AdvertisementResponse();
            _mockMapper.Setup(mapper => mapper.Map<Advertisement, AdvertisementResponse>(advertisement))
                .Returns(advertisementResponse);

            // Act
            var result = await _controller.GetAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<AdvertisementResponse>(okResult.Value);
            Assert.Equal(advertisementResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidAdvertisementID_ReturnsNotFound()
        {
            // Arrange
            var advertisement = new Advertisement();
            _mockAdvertisementData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(advertisement);
            var advertisementResponse = new AdvertisementResponse();
            _mockMapper.Setup(mapper => mapper.Map<Advertisement, AdvertisementResponse>(advertisement))
                .Returns(advertisementResponse);

            // Act
            var result = await _controller.GetAsync(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }
        
        [Fact]
        public async Task PostAsync_WithValidData_ReturnsCreatedAtRouteResult()
        {
            // Arrange
            var advertisementRequest = new AdvertisementRequest();

            _mockAdvertisementDomain.Setup(domain => domain.CreateAsync(It.IsAny<Advertisement>(), 1)).ReturnsAsync(true);
            var advertisement = new Advertisement();
            _mockMapper.Setup(mapper => mapper.Map<AdvertisementRequest, Advertisement>(It.IsAny<AdvertisementRequest>()))
                .Returns(advertisement);

            // Act
            var result = await _controller.PostAsync(advertisementRequest, 1);

            // Assert
            Assert.IsType<CreatedAtRouteResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithInvalidWorkerID_ReturnsBadRequest()
        {
            // Arrange
            var advertisementRequest = new AdvertisementRequest();

            _mockAdvertisementDomain.Setup(domain => domain.CreateAsync(It.IsAny<Advertisement>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PostAsync(advertisementRequest, 1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var advertisementRequest = new AdvertisementRequest();
            _mockAdvertisementDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Advertisement>(), 1)).ReturnsAsync(true);

            // Act
            var result = await _controller.PutAsync(1, advertisementRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithInvalidAdvertisementID_ReturnsNotFound()
        {
            // Arrange
            var advertisementRequest = new AdvertisementRequest();

            _mockAdvertisementDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Advertisement>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PutAsync(1, advertisementRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var advertisement = new Advertisement();

            _mockAdvertisementDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(true);
            var advertisementResponse = new AdvertisementResponse();
            _mockMapper.Setup(mapper => mapper.Map<Advertisement, AdvertisementResponse>(advertisement))
                .Returns(advertisementResponse);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidAdvertisementID_ReturnsNotFound()
        {
            // Arrange
            _mockAdvertisementDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
        
    }
}
