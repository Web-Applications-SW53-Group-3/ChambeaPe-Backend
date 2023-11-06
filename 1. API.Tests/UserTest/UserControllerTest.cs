using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Users;
using _3._Data.Model;
using _3._Data.Users;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace _1._API.Tests.UserTest
{
    public class UserControllerTest
    {
        private readonly UserController _controller;
        private readonly Mock<IUserData> _mockUserData;
        private readonly Mock<IUserDomain> _mockUserDomain;
        private readonly Mock<IMapper> _mockMapper;

        public UserControllerTest()
        {
            _mockUserData = new Mock<IUserData>();
            _mockUserDomain = new Mock<IUserDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<UserController>> mockLogger = new();

            _controller = new UserController(
                _mockUserData.Object,
                _mockUserDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var userList = new List<User>();
            _mockUserData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(userList);
            var userResponseList = new List<UserResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<User>, List<UserResponse>>(userList))
                .Returns(userResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<UserResponse>>(okResult.Value);
            Assert.Equal(userResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidUserID_ReturnsOkResult()
        {
            // Arrange
            var user = new User();
            _mockUserData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(user);
            var userResponse = new UserResponse();
            _mockMapper.Setup(mapper => mapper.Map<User, UserResponse>(user))
                .Returns(userResponse);

            // Act
            var result = await _controller.GetAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<UserResponse>(okResult.Value);
            Assert.Equal(userResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidUserID_ReturnsNotFound()
        {
            // Arrange
            var user = new User();
            _mockUserData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(user);
            var userResponse = new UserResponse();
            _mockMapper.Setup(mapper => mapper.Map<User, UserResponse>(user))
                .Returns(userResponse);

            // Act
            var result = await _controller.GetAsync(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.CreateAsync(It.IsAny<User>(), "-"));
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());

            // Act
            var result = await _controller.PostAsync(userRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.CreateAsync(It.IsAny<User>(), "-"))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.PostAsync(userRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("EmailAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PostAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.CreateAsync(It.IsAny<User>(), "-"))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.PostAsync(userRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("PhoneNumberAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PostAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.CreateAsync(It.IsAny<User>(), "-"))
                .Throws<Exception>();

            // Act
            var result = await _controller.PostAsync(userRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.UpdateAsync(It.IsAny<User>(), 1, "-"));
            _mockMapper.Setup(mapper => mapper.Map<UserRequest, User>(It.IsAny<UserRequest>()))
                .Returns(new User());

            // Act
            var result = await _controller.PutAsync(1, userRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithEmailAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.UpdateAsync(It.IsAny<User>(), 1, "-"))
                .Throws<EmailAlreadyExistsException>();

            // Act
            var result = await _controller.PutAsync(1, userRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("EmailAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PutAsync_WithPhoneNumberAlreadyExists_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.UpdateAsync(It.IsAny<User>(), 1, "-"))
                .Throws<PhoneNumberAlreadyExistsException>();

            // Act
            var result = await _controller.PutAsync(1, userRequest);

            // Assert
            var badRequest = Assert.IsType<BadRequestObjectResult>(result);
            var error = (Dictionary<string, string>)badRequest.Value!;
            Assert.Equal("PhoneNumberAlreadyExists", error["error"]);
        }

        [Fact]
        public async Task PutAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            var userRequest = new UserRequest();

            _mockUserDomain.Setup(domain => domain.UpdateAsync(It.IsAny<User>(), 1, "-"))
                .Throws<Exception>();

            // Act
            var result = await _controller.PutAsync(1, userRequest);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            _mockUserDomain.Setup(domain => domain.DeleteAsync(1));

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidUserID_ReturnsNotFound()
        {
            // Arrange
            _mockUserDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithOtherExceptions_ReturnsBadRequest()
        {
            // Arrange
            _mockUserDomain.Setup(domain => domain.DeleteAsync(1))
                .Throws<Exception>();

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
