using _1._API.Controllers;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Skills;
using _3._Data.Skills;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using _3._Data.Model;

namespace _1._API.Tests.SkillTest
{
    public class SkillControllerTest
    {
        private readonly SkillController _controller;
        private readonly Mock<ISkillData> _mockSkillData;
        private readonly Mock<ISkillDomain> _mockSkillDomain;
        private readonly Mock<IMapper> _mockMapper;

        public SkillControllerTest()
        {
            _mockSkillData = new Mock<ISkillData>();
            _mockSkillDomain = new Mock<ISkillDomain>();
            _mockMapper = new Mock<IMapper>();
            Mock<ILogger<SkillController>> mockLogger = new();

            _controller = new SkillController(
                _mockSkillData.Object,
                _mockSkillDomain.Object,
                _mockMapper.Object,
                mockLogger.Object
            );
        }

        [Fact]
        public async Task GetAsync_ReturnsOkResult()
        {
            // Arrange
            var skillList = new List<Skill>();
            _mockSkillData.Setup(repo => repo.GetAllAsync()).ReturnsAsync(skillList);
            var skillResponseList = new List<SkillResponse>();
            _mockMapper.Setup(mapper => mapper.Map<List<Skill>, List<SkillResponse>>(skillList))
                .Returns(skillResponseList);

            // Act
            var result = await _controller.GetAsync();

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<List<SkillResponse>>(okResult.Value);
            Assert.Equal(skillResponseList, model);
        }

        [Fact]
        public async Task GetAsync_WithValidSkillID_ReturnsOkResult()
        {
            // Arrange
            var skill = new Skill();
            _mockSkillData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(skill);
            var skillResponse = new SkillResponse();
            _mockMapper.Setup(mapper => mapper.Map<Skill, SkillResponse>(skill))
                .Returns(skillResponse);

            // Act
            var result = await _controller.GetAsync(1);

            // Assert
            var okResult = Assert.IsType<OkObjectResult>(result.Result);
            var model = Assert.IsType<SkillResponse>(okResult.Value);
            Assert.Equal(skillResponse, model);
        }

        [Fact]
        public async Task GetAsync_WithInvalidSkillID_ReturnsNotFound()
        {
            // Arrange
            var skill = new Skill();
            _mockSkillData.Setup(repo => repo.GetByIdAsync(1)).ReturnsAsync(skill);
            var skillResponse = new SkillResponse();
            _mockMapper.Setup(mapper => mapper.Map<Skill, SkillResponse>(skill))
                .Returns(skillResponse);

            // Act
            var result = await _controller.GetAsync(2);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result.Result);
        }

        [Fact]
        public async Task PostAsync_WithValidData_ReturnsCreatedAtRouteResult()
        {
            // Arrange
            var skillRequest = new SkillRequest();

            _mockSkillDomain.Setup(domain => domain.CreateAsync(It.IsAny<Skill>(), 1)).ReturnsAsync(true);
            var skill = new Skill();
            _mockMapper.Setup(mapper => mapper.Map<SkillRequest, Skill>(It.IsAny<SkillRequest>()))
                .Returns(skill);

            // Act
            var result = await _controller.PostAsync(skillRequest, 1);

            // Assert
            Assert.IsType<CreatedAtRouteResult>(result);
        }

        [Fact]
        public async Task PostAsync_WithInvalidWorkerID_ReturnsBadRequest()
        {
            // Arrange
            var skillRequest = new SkillRequest();

            _mockSkillDomain.Setup(domain => domain.CreateAsync(It.IsAny<Skill>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PostAsync(skillRequest, 1);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var skillRequest = new SkillRequest();
            _mockSkillDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Skill>(), 1)).ReturnsAsync(true);

            // Act
            var result = await _controller.PutAsync(1, skillRequest);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task PutAsync_WithInvalidSkillID_ReturnsNotFound()
        {
            // Arrange
            var skillRequest = new SkillRequest();

            _mockSkillDomain.Setup(domain => domain.UpdateAsync(It.IsAny<Skill>(), 1)).ReturnsAsync(false);

            // Act
            var result = await _controller.PutAsync(1, skillRequest);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithValidData_ReturnsOkResult()
        {
            // Arrange
            var skill = new Skill();

            _mockSkillDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(true);
            var skillResponse = new SkillResponse();
            _mockMapper.Setup(mapper => mapper.Map<Skill, SkillResponse>(skill))
                .Returns(skillResponse);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public async Task DeleteAsync_WithInvalidSkillID_ReturnsNotFound()
        {
            // Arrange
            _mockSkillDomain.Setup(domain => domain.DeleteAsync(1)).ReturnsAsync(false);

            // Act
            var result = await _controller.DeleteAsync(1);

            // Assert
            Assert.IsType<NotFoundObjectResult>(result);
        }
    }
}
