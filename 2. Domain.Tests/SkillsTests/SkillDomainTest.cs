
using _2._Domain.Skills;
using _3._Data.Model;
using _2._Domain.Workers;
using _2._Domain.Exceptions;
using _3._Data.Skills;
using NSubstitute;

public class SkillDomainTests
{
    [Fact]
    public async Task CreateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var newSkill = new Skill();
        var workerId = 1;

        workerDomainMock.ExistsByWorkerId(workerId).Returns(true);
        skillDataMock.CreateAsync(newSkill).Returns(true);

        // Act
        var result = await skillDomain.CreateAsync(newSkill, workerId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task CreateAsync_InvalidWorker_ReturnsFalse()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var newSkill = new Skill();
        var workerId = 1;

        workerDomainMock.ExistsByWorkerId(workerId).Returns(false);

        // Act
        var result = await skillDomain.CreateAsync(newSkill, workerId);

        // Assert
        Assert.False(result);
    }

    [Fact]
    public async Task UpdateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var skillToUpdate = new Skill();
        var skillId = 1;

        skillDataMock.GetByIdAsync(skillId).Returns(Task.FromResult(skillToUpdate));
        skillDataMock.UpdateAsync(skillToUpdate, skillId).Returns(true);

        // Act
        var result = await skillDomain.UpdateAsync(skillToUpdate, skillId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task UpdateAsync_InvalidSkill_ThrowsException()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var skillToUpdate = new Skill();
        var skillId = 1;

        skillDataMock.GetByIdAsync(skillId).Returns(Task.FromResult((Skill)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidSkillIDException>(async () =>
        {
            await skillDomain.UpdateAsync(skillToUpdate, skillId);
        });
    }

    [Fact]
    public async Task DeleteAsync_ValidSkill_ReturnsTrue()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var skillId = 1;

        skillDataMock.GetByIdAsync(skillId).Returns(Task.FromResult(new Skill()));
        skillDataMock.DeleteAsync(skillId).Returns(true);

        // Act
        var result = await skillDomain.DeleteAsync(skillId);

        // Assert
        Assert.True(result);
    }

    [Fact]
    public async Task DeleteAsync_InvalidSkill_ThrowsException()
    {
        // Arrange
        var skillDataMock = Substitute.For<ISkillData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();

        var skillDomain = new SkillDomain(skillDataMock, workerDomainMock);

        var skillId = 1;

        skillDataMock.GetByIdAsync(skillId).Returns(Task.FromResult((Skill)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidSkillIDException>(async () =>
        {
            await skillDomain.DeleteAsync(skillId);
        });
    }
}
