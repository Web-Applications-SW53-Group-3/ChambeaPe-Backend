using _2._Domain.Exceptions;
using _2._Domain.Users;
using _2._Domain.Workers;
using _3._Data.Model;
using _3._Data.Users;
using _3._Data.Workers;
using AutoMapper;
using NSubstitute;

namespace _2._Domain.Tests.WorkersTests;

public class WorkerDomainTest
{
    //Todo: Happy Path CreateAsync
    [Fact]
    public async void CreateAsync_ValidData_ReturnTrue()
    {
        // Arrange
        Worker worker = new Worker()
        {
            Id = 1,
        };
        User user = new User()
        {
            Id = 1,
            UserRole = "W",
            Email = "rosita@gmail.com"
        };
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        userDomainMock.CreateAsync(user, user.UserRole).Returns(Task.FromResult(true));
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(user));
        workerDataMock.CreateAsync(worker).Returns(Task.FromResult(true));

        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = await workerDomain.CreateAsync(worker, user);

        // Assert
        Assert.True(actualResult);
    }

    //Todo: Unhappy path user registration failed
    [Fact]
    public async void CreateAsync_UserNotFound_ThrowsUserRegistrationException()
    {
        // Arrange
        Worker worker = new Worker()
        {
            Id = 1,
        };
        User user = new User()
        {
            Id = 1,
            UserRole = "W",
            Email = "rosita@gmail.com"
        };
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        userDomainMock.CreateAsync(user, user.UserRole).Returns(Task.FromResult(true));
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(null));
        workerDataMock.CreateAsync(worker).Returns(Task.FromResult(true));

        // Act
        UserDomain userDomain = new UserDomain(userDataMock, mapper);
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomain, userDataMock, mapper);

        async Task CreateAsyncWithExceptionHandling()
        {
            await workerDomain.CreateAsync(worker, user);
        }

        await Assert.ThrowsAsync<UserRegistrationException>(CreateAsyncWithExceptionHandling);
    }

    //Todo: Happy Path exists by worker id
    [Fact]
    public async void ExistsByWorkerId_ValidData_ReturnTrue()
    {
        // Arrange
        Worker worker = new Worker()
        {
            Id = 1,
        };
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        workerDataMock.ExistsByIdAsync(worker.Id)!.Returns(Task.FromResult<Worker>(worker));

        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = await workerDomain.ExistsByWorkerId(worker.Id);

        // Assert
        Assert.True(actualResult);
    }

    //Todo: Unhappy Path exists by worker id
    [Fact]
    public async void ExistsByWorkerId_ValidData_ThrowInvalidWorkerIDException()
    {
        // Arrange
        Worker worker = new Worker();
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        workerDataMock.ExistsByIdAsync(worker.Id)!.Returns(Task.FromResult<Worker>(null));

        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = async () => await workerDomain.ExistsByWorkerId(worker.Id);
        // Assert
        await Assert.ThrowsAsync<InvalidWorkerIDException>(actualResult);
    }

    //todo: Happy path UpdateAsync
    [Fact]
    public async void UpdateAsync_ValidData_ReturnTrue()
    {
        // Arrange
        Worker worker = new Worker()
        {
            Id = 1,
        };
        User user = new User()
        {
            Id = 1,
            UserRole = "W",
            Email = "rosita@gmail.com",
        };
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        workerDataMock.GetByIdAsync(worker.Id).Returns(Task.FromResult<Worker>(worker));
        userDomainMock.UpdateAsync(user, worker.UserId, user.UserRole).Returns(Task.FromResult(true));
        userDataMock.GetByIdAsync(worker.UserId).Returns(Task.FromResult<User>(user));
        workerDataMock.UpdateAsync(worker, worker.Id).Returns(Task.FromResult(true));

        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = await workerDomain.UpdateAsync(worker, user, worker.Id);

        // Assert
        Assert.True(actualResult);
    }

    //todo: Unhappy path UpdateAsync
    // [Fact]
    // public async void UpdateAsync_InvalidData_ThrowInvalidUserIDException()
    // {
    //     // Arrange
    //     Worker worker = new Worker()
    //     {
    //         Id = 1,
    //     };
    //     User user = new User()
    //     {
    //         Id = 1,
    //         Email = "rosita@gmail.com",
    //         
    //     };
    //     IMapper mapper = Substitute.For<IMapper>();
    //     var workerDataMock = Substitute.For<IWorkerData>();
    //     var userDataMock = Substitute.For<IUserData>();
    //     var userDomainMock = Substitute.For<IUserDomain>();
    //
    //     workerDataMock.GetByIdAsync(worker.Id).Returns(Task.FromResult<Worker>(null));
    //     userDomainMock.UpdateAsync(user, worker.UserId, user.UserRole).Returns(Task.FromResult(false));
    //     userDataMock.GetByIdAsync(worker.UserId).Returns(Task.FromResult<User>(user));
    //     workerDataMock.UpdateAsync(worker, worker.Id).Returns(Task.FromResult(true));
    //
    //     // Act
    //     WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
    //     var actualResult = async () => await workerDomain.UpdateAsync(worker, user, worker.Id);
    //     
    //     // Assert
    //     await Assert.ThrowsAsync<InvalidUserIDException>(actualResult);
    //     
    // }
    
    //todo: Happy path DeleteAsync
    [Fact]
    public async void DeleteAsync_ValidData_ReturnTrue()
    {
        // Arrange
        Worker worker = new Worker()
        {
            Id = 1,
        };
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        workerDataMock.GetByIdAsync(worker.Id).Returns(Task.FromResult<Worker>(worker));
        userDomainMock.DeleteAsync(worker.UserId).Returns(Task.FromResult(true));
        userDataMock.DeleteAsync(worker.UserId).Returns(Task.FromResult(true));
        workerDataMock.DeleteAsync(worker.Id).Returns(Task.FromResult(true));

        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = await workerDomain.DeleteAsync(worker.Id);

        // Assert
        Assert.True(actualResult);
    }
    
    //todo: Unhappy path DeleteAsync
    [Fact]
    public async void DeleteAsync_InvalidData_ThrowInvalidUserIDException()
    {
        // Arrange
        Worker worker = new Worker();
        IMapper mapper = Substitute.For<IMapper>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var userDataMock = Substitute.For<IUserData>();
        var userDomainMock = Substitute.For<IUserDomain>();

        workerDataMock.GetByIdAsync(worker.Id).Returns(Task.FromResult<Worker>(null));
        userDomainMock.DeleteAsync(worker.UserId).Returns(Task.FromResult(true));
        userDataMock.DeleteAsync(worker.UserId).Returns(Task.FromResult(true));
        workerDataMock.DeleteAsync(worker.Id).Returns(Task.FromResult(true));
        
        // Act
        WorkerDomain workerDomain = new WorkerDomain(workerDataMock, userDomainMock, userDataMock, mapper);
        var actualResult = async () => await workerDomain.DeleteAsync(worker.Id);

        // Assert
        await Assert.ThrowsAsync<InvalidUserIDException>(actualResult);
        
    }
    
    
}