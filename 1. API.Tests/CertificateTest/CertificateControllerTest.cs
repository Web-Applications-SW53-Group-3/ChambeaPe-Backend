using _1._API.Controllers;
using _1._API.Request;
using _2._Domain.Certificates;
using _3._Data.Certificates;
using _3._Data.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;


namespace _1._API.Tests.CertificateTest
{
    public class CertificateControllerTest
    {
        private readonly CertificateController _controller;
        private readonly Mock<ICertificateData> _mockCertificateData;
        private readonly Mock<ICertificateDomain> _mockCertificateDomain;
        private readonly Mock<IMapper> _mockMapper;

        public CertificateControllerTest()
        {
            _mockCertificateData = new Mock<ICertificateData>();
            _mockCertificateDomain = new Mock<ICertificateDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<CertificateController>> mockLogger = new();

            _controller = new CertificateController(
                _mockCertificateData.Object,
                _mockCertificateDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var certificateList = new List<Certificate>();
            _mockCertificateData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(certificateList);
            var certificateResponseList = new List<CertificateResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Certificate>, List<CertificateResponse>>(certificateList))
                .Returns(certificateResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<CertificateResponse>>(okResult.Value);
            Assert.Equal(certificateResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidCertificateID_ReturnsOkResult()
        {
            // Arrange
            var certificate = new Certificate();
            _mockCertificateData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(certificate);
            var certificateResponse = new CertificateResponse();
            _mockMapper.Setup(mapper => mapper.Map<Certificate, CertificateResponse>(certificate))
                .Returns(certificateResponse);

            // Act
            var result = await _controller.GetAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<CertificateResponse>(okResult.Value);
            Assert.Equal(certificateResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidCertificateID_ReturnsNotFound()
        {
            // Arrange
            var certificate = new Certificate();
            _mockCertificateData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(certificate);
            var certificateResponse = new CertificateResponse();
            _mockMapper.Setup(mapper => mapper.Map<Certificate, CertificateResponse>(certificate))
                .Returns(certificateResponse);

            // Act
            var result = await _controller.GetAsync(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsCreatedAtRouteResult()
        {
            // Arrange
            var certificateRequest = new CertificateRequest();

            _mockCertificateDomain.Setup(domain => domain.CreateAsync(It.IsAny<Certificate>(), 1)).ReturnsAsync(true);
            var certificate = new Certificate();
            _mockMapper.Setup(mapper => mapper.Map<CertificateRequest, Certificate>(It.IsAny<CertificateRequest>()))
                .Returns(certificate);

            // Act
            var result = await _controller.PostAsync(certificateRequest, 1);

            // Assert
            Assert.IsType<CreatedAtRouteResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithInvalidWorkerID_ReturnsBadRequest()
        {
            // Arrange
            var certificateRequest = new CertificateRequest();

            _mockCertificateDomain.Setup(domain => domain.CreateAsync(It.IsAny<Certificate>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PostAsync(certificateRequest, 1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var certificateRequest = new CertificateRequest();
            _mockCertificateDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Certificate>(), 1)).ReturnsAsync(true);

            // Act
            var result = await _controller.PutAsync(1, certificateRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithInvalidCertificateID_ReturnsNotFound()
        {
            // Arrange
            var certificateRequest = new CertificateRequest();

            _mockCertificateDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Certificate>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PutAsync(1, certificateRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var certificate = new Certificate();

            _mockCertificateDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(true);
            var certificateResponse = new CertificateResponse();
            _mockMapper.Setup(mapper => mapper.Map<Certificate, CertificateResponse>(certificate))
                .Returns(certificateResponse);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidCertificateID_ReturnsNotFound()
        {
            // Arrange
            _mockCertificateDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}
