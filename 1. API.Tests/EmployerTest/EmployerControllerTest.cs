using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Employers;
using _2._Domain.Exceptions;
using _3._Data.Model;
using _3._Data.Employers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace _1._API.Tests.EmployerTest
{
    public class EmployerControllerTest
    {
        private readonly EmployerController _controller;
        private readonly Mock<IEmployerData> _mockEmployerData;
        private readonly Mock<IEmployerDomain> _mockEmployerDomain;
        private readonly Mock<IMapper> _mockMapper;

        public EmployerControllerTest()
        {
            _mockEmployerData = new Mock<IEmployerData>();
            _mockEmployerDomain = new Mock<IEmployerDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<EmployerController>> mockLogger = new();

            _controller = new EmployerController(
                _mockEmployerData.Object,
                _mockEmployerDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var employerList = new List<Employer>();
            _mockEmployerData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(employerList);
            var employerResponseList = new List<EmployerResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Employer>, List<EmployerResponse>>(employerList))
                .Returns(employerResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<EmployerResponse>>(okResult.Value);
            Assert.Equal(employerResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidEmployerID_ReturnsOkResult()
        {
            // Arrange
            var employer = new Employer();
            _mockEmployerData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(employer);
            var employerResponse = new EmployerResponse();
            _mockMapper.Setup(mapper => mapper.Map<Employer, EmployerResponse>(employer))
                .Returns(employerResponse);

            // Act
            var result = await _controller.Get(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<EmployerResponse>(okResult.Value);
            Assert.Equal(employerResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidEmployerID_ReturnsNotFound()
        {
            // Arrange
            var employer = new Employer();
            _mockEmployerData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(employer);
            var employerResponse = new EmployerResponse();
            _mockMapper.Setup(mapper => mapper.Map<Employer, EmployerResponse>(employer))
                .Returns(employerResponse);

            // Act
            var result = await _controller.Get(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockMapper.Setup(mapper => mapper.Map<EmployerRequest, UserRequest>(It.IsAny<EmployerRequest>()))
                .Returns(new UserRequest());
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());
            _mockMapper.Setup(mapper => mapper.Map<EmployerRequest, Employer>(It.IsAny<EmployerRequest>()))
                .Returns(new Employer());
            _mockEmployerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Employer>(), It.IsAny<User>()));

            // Act
            var result = await _controller.Post(employerRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Employer>(), It.IsAny<User>()))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.Post(employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Employer>(), It.IsAny<User>()))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.Post(employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithUserRegistrationError_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Employer>(), It.IsAny<User>()))
                .Throws<UserRegistrationException>();

            // Act
            var result = await _controller.Post(employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
         
        }

        [Fact]
        public async Task PostAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Employer>(), It.IsAny<User>()))
                .ThrowsAsync(new UserRegistrationException());

            // Act
            var result = await _controller.Post(employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockMapper.Setup(mapper => mapper.Map<EmployerRequest, UserRequest>(It.IsAny<EmployerRequest>()))
                .Returns(new UserRequest());
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());
            _mockMapper.Setup(mapper => mapper.Map<EmployerRequest, Employer>(It.IsAny<EmployerRequest>()))
                .Returns(new Employer());
            _mockEmployerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Employer>(), It.IsAny<User>(), 1));

            // Act
            var result = await _controller.Put(1, employerRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Employer>(), It.IsAny<User>(), 1))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.Put(1, employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Employer>(), It.IsAny<User>(), 1))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.Put(1, employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithInvalidUserID_ReturnsNotFound()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Employer>(), It.IsAny<User>(), 1))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.Put(1, employerRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var employerRequest = new EmployerRequest();

            _mockEmployerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Employer>(), It.IsAny<User>(), 1))
                .Throws<Exception>();

            // Act
            var result = await _controller.Put(1, employerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            _mockEmployerDomain.Setup(domain => domain.DeleteAsync(1));

            // Act
            var result = await _controller.Delete(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidEmployerID_ReturnsNotFound()
        {
            // Arrange
            _mockEmployerDomain.Setup(domain => domain.DeleteAsync(1))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.Delete(1);

            // Assert
           Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            _mockEmployerDomain.Setup(domain => domain.DeleteAsync(1))
                .Throws<Exception>();

            // Act
            var result = await _controller.Delete(1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
