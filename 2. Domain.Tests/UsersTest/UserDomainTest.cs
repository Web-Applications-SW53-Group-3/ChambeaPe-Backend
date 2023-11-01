using _2._Domain.Exceptions;
using _2._Domain.Users;
using _3._Data.Model;
using _3._Data.Users;
using NSubstitute.ExceptionExtensions;

namespace _2._Domain.Tests.UsersTest;
using NSubstitute;
public class UserDomainTest
{
    [Fact]
    //Todo: Happy Path CreateAsync
    public async void CreateAsync_ValidData_ReturnTrue()
    {
        // Arrange
        User user = new User()
        {
            FirstName = "Richard",
            LastName = "Zubi",
            Email = "zubieta@gmail.com",
            PhoneNumber = "949911123",
            Description = "I am a developer",
        };
    
        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(null));
        userDataMock.GetByPhoneNumberAsync(user.PhoneNumber).Returns(Task.FromResult<User>(null));
        userDataMock.CreateAsync(user).Returns(Task.FromResult(true));
    
        // Act
        UserDomain userDomain = new UserDomain(userDataMock);
        var actualResult = await userDomain.CreateAsync(user);
    
        // Assert
        Assert.True(actualResult);
    }
    //Todo: Unhappy path email already exists
    [Fact]
    public async void CreateAsync_InvalidDataEmailAlreadyExists_ReturnFalse()
    {
        // Arrange
        User user = new User();

        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(user)); 
        userDataMock.GetByPhoneNumberAsync(user.PhoneNumber).Returns(Task.FromResult<User>(null)); 
        userDataMock.CreateAsync(user).Returns(Task.FromResult(true));
    
        // Act
        UserDomain userDomain = new UserDomain(userDataMock);
        var actualResult = async () => await userDomain.CreateAsync(user);
        
        // Assert
        await Assert.ThrowsAsync<EmailAlreadyExistsException>(actualResult); 
    }
    
    //Todo: Unhappy path phone number already exists
    [Fact]
    public async void CreateAsync_InvalidDataPhoneNumberAlreadyExists_ReturnFalse()
    {
        // Arrange
        User user = new User();

        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(null)); 
        userDataMock.GetByPhoneNumberAsync(user.PhoneNumber).Returns(Task.FromResult<User>(user)); 
        userDataMock.CreateAsync(user).Returns(Task.FromResult(true));
    
        // Act
        UserDomain userDomain = new UserDomain(userDataMock);
        var actualResult = async () => await userDomain.CreateAsync(user);
        
        // Assert
        await Assert.ThrowsAsync<PhoneNumberAlreadyExistsException>(actualResult); 
    }
    
//todo: Happy path UpdateAsync
    [Fact]
    public async void UpdateAsync_ValidData_ReturnTrue()
    {
        // Arrange
        User user = new User()
        {
            Id = 1,
            Email = "zubieta@gmail.com",
            PhoneNumber = "949911123",
            Description = "I am a developer",
        };
        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(user));
        userDataMock.GetByPhoneNumberAsync(user.PhoneNumber).Returns(Task.FromResult<User>(user));
        userDataMock.UpdateAsync(user, user.Id).Returns(Task.FromResult(true));

        // Act
        UserDomain userDomain  = new UserDomain(userDataMock);
        var actualResult = await userDomain.UpdateAsync(user, user.Id);
        
        // Assert
        Assert.Equal(true, actualResult); 
        
    }

    //todo: DeleteAsync
    [Fact]
    public async void DeleteAsync_ValidData_ReturnTrue()
    {
        // Arrange
        User user = new User()
        {
            Id = 1,
        };
        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByIdAsync(user.Id).Returns(Task.FromResult<User>(user)); 
        userDataMock.DeleteAsync(user.Id).Returns(Task.FromResult(true));
        
        // Act
        UserDomain userDomain = new UserDomain(userDataMock);
        var actualResult = await userDomain.DeleteAsync(user.Id);
        
        // Assert
        Assert.True(actualResult);
    }
    
    //unphappy path delete
    [Fact]
    public async void DeleteAsync_InvalidData_ReturnFalse()
    {
        // Arrange
        User user = new User()
        {
            Id = 1,
        };
        
        var userDataMock = Substitute.For<IUserData>();
        userDataMock.GetByIdAsync(user.Id).Returns(Task.FromResult<User>(null));
        userDataMock.DeleteAsync(user.Id).Returns(Task.FromResult(true));
        
        // Act
        UserDomain userDomain = new UserDomain(userDataMock);
        Func<Task> actualResult = async () => await userDomain.DeleteAsync(user.Id);
        
        // Assert
        await Assert.ThrowsAsync<InvalidUserIDException>(actualResult);
    }
    

}