using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Workers;
using _3._Data.Model;
using _3._Data.Workers;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace _1._API.Tests.WorkerTest
{
    public class WorkerControllerTest
    {
        private readonly WorkerController _controller;
        private readonly Mock<IWorkerData> _mockWorkerData;
        private readonly Mock<IWorkerDomain> _mockWorkerDomain;
        private readonly Mock<IMapper> _mockMapper;

        public WorkerControllerTest()
        {
            _mockWorkerData = new Mock<IWorkerData>();
            _mockWorkerDomain = new Mock<IWorkerDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<WorkerController>> mockLogger = new();

            _controller = new WorkerController(
                _mockWorkerData.Object,
                _mockWorkerDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var workerList = new List<Worker>();
            _mockWorkerData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(workerList);
            var workerResponseList = new List<WorkerResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Worker>, List<WorkerResponse>>(workerList))
                .Returns(workerResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<WorkerResponse>>(okResult.Value);
            Assert.Equal(workerResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidWorkerID_ReturnsOkResult()
        {
            // Arrange
            var worker = new Worker();
            _mockWorkerData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(worker);
            var workerResponse = new WorkerResponse();
            _mockMapper.Setup(mapper => mapper.Map<Worker, WorkerResponse>(worker))
                .Returns(workerResponse);

            // Act
            var result = await _controller.Get(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<WorkerResponse>(okResult.Value);
            Assert.Equal(workerResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidWorkerID_ReturnsNotFound()
        {
            // Arrange
            var worker = new Worker();
            _mockWorkerData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(worker);
            var workerResponse = new WorkerResponse();
            _mockMapper.Setup(mapper => mapper.Map<Worker, WorkerResponse>(worker))
                .Returns(workerResponse);

            // Act
            var result = await _controller.Get(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockMapper.Setup(mapper => mapper.Map<WorkerRequest, UserRequest>(It.IsAny<WorkerRequest>()))
                .Returns(new UserRequest());
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());
            _mockMapper.Setup(mapper => mapper.Map<WorkerRequest, Worker>(It.IsAny<WorkerRequest>()))
                .Returns(new Worker());
            _mockWorkerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Worker>(), It.IsAny<User>()));

            // Act
            var result = await _controller.Post(workerRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Worker>(), It.IsAny<User>()))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.Post(workerRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("EmailAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PostAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Worker>(), It.IsAny<User>()))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.Post(workerRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("PhoneNumberAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PostAsync_WithUserRegistrationError_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Worker>(), It.IsAny<User>()))
                .Throws<UserRegistrationException>();

            // Act
            var result = await _controller.Post(workerRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("UserRegistrationError", error["error"]);
        }

        [Fact]
        public async Task PostAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.CreateAsync(It.IsAny<Worker>(), It.IsAny<User>()))
                .Throws<Exception>();

            // Act
            var result = await _controller.Post(workerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockMapper.Setup(mapper => mapper.Map<WorkerRequest, UserRequest>(It.IsAny<WorkerRequest>()))
                .Returns(new UserRequest());
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());
            _mockMapper.Setup(mapper => mapper.Map<WorkerRequest, Worker>(It.IsAny<WorkerRequest>()))
                .Returns(new Worker());
            _mockWorkerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Worker>(), It.IsAny<User>(), 1));

            // Act
            var result = await _controller.Put(1, workerRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Worker>(), It.IsAny<User>(), 1))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.Put(1, workerRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("EmailAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PutAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Worker>(), It.IsAny<User>(), 1))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.Put(1, workerRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("PhoneNumberAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PutAsync_WithInvalidUserID_ReturnsNotFound()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Worker>(), It.IsAny<User>(), 1))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.Put(1, workerRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var workerRequest = new WorkerRequest();

            _mockWorkerDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Worker>(), It.IsAny<User>(), 1))
                .Throws<Exception>();

            // Act
            var result = await _controller.Put(1, workerRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            _mockWorkerDomain.Setup(domain => domain.DeleteAsync(1));

            // Act
            var result = await _controller.Delete(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidWorkerID_ReturnsNotFound()
        {
            // Arrange
            _mockWorkerDomain.Setup(domain => domain.DeleteAsync(1))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.Delete(1);

            // Assert
            var notFound = Assert.IsType<NotFoundObjectResult>(result);
            var error = (Dictionary<string, string>)notFound.Value!;
            Assert.Equal("InvalidWorkerID", error["error"]);
        }

        [Fact]
        public async Task DeleteAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            _mockWorkerDomain.Setup(domain => domain.DeleteAsync(1))
                .Throws<Exception>();

            // Act
            var result = await _controller.Delete(1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
