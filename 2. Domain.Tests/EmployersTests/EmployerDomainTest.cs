using _2._Domain.Employers;
using _2._Domain.Exceptions;
using _2._Domain.Users;
using _2._Domain.Workers;
using _3._Data.Employers;
using _3._Data.Model;
using _3._Data.Users;
using _3._Data.Workers;
using NSubstitute;

namespace _2._Domain.Tests.EmployersTests;

public class EmployerDomainTest
{
    //Happy Path Create_ValidData_ResultTrue
    [Fact]
    public async Task Create_ValidData_ResultTrue()
    {
        //Arrange
        Employer employer = new Employer()
        {
            Id = 1,
        };
        User user = new User()
        {
            Id = 1,
        };
        var employerDataMock = Substitute.For<IEmployerData>();
        var userDomainMock = Substitute.For<IUserDomain>();
        var userDataMock = Substitute.For<IUserData>();

        
        userDomainMock.CreateAsync(user, "E").Returns(true);
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(user));
        employerDataMock.CreateAsync(employer).Returns(true);
        
        //Act
        EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
        var actualResult = await employerDomain.CreateAsync(employer, user);
        
        //Assert
        Assert.True(actualResult);
        
    }
    
    //Unhappy Path Create_InvalidData_ResultFalse
    [Fact]
    public async Task Create_InvalidData_ThrowUserRegistrationException()
    {
        //Arrange
        Employer employer = new Employer()
        {
            Id = 1,
        };
        User user = new User()
        {
            Id = 1,
        };
        var employerDataMock = Substitute.For<IEmployerData>();
        var userDomainMock = Substitute.For<IUserDomain>();
        var userDataMock = Substitute.For<IUserData>();

        
        userDomainMock.CreateAsync(user, "E").Returns(true);
        userDataMock.GetByEmailAsync(user.Email).Returns(Task.FromResult<User>(null));
        employerDataMock.CreateAsync(employer).Returns(true);
        
        //Act
        EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
        var actualResult = async () => await employerDomain.CreateAsync(employer, user);

        //Assert
        await Assert.ThrowsAsync<UserRegistrationException>(actualResult);

    }
    
    //Happy Path Update_ValidData_ResultTrue
    [Fact]
    public async Task Update_ValidData_ResultTrue()
    {
        // Arrange
        var employer = new Employer { Id = 1 };
        var user = new User { Id = 1 };
        
        var employerDataMock = Substitute.For<IEmployerData>();
        var userDomainMock = Substitute.For<IUserDomain>();
        var userDataMock = Substitute.For<IUserData>();



        employerDataMock.GetByIdAsync(employer.Id).Returns(Task.FromResult<Employer>(employer));
        userDomainMock.UpdateAsync(user, employer.UserId, "E").Returns(true);
        userDataMock.GetByIdAsync(employer.UserId).Returns(Task.FromResult<User>(user));
        userDataMock.GetByIdAsync(employer.UserId).Returns(Task.FromResult<User>(user));
        employerDataMock.UpdateAsync(employer, employer.Id).Returns(true);
        
        EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
        var actualResult = await employerDomain.UpdateAsync(employer, user,  employer.Id);

        Assert.True(actualResult);
        
    }
    
    //
    // //Unhappy Path Update_InvalidData_ThrowInvalidUserIDException
    // [Fact]
    // public async Task UpdateAsync_InvalidEmployer_ThrowsInvalidUserIDException()
    // {
    //     // Arrange
    //     var employer = new Employer { Id = 1 };
    //     var user = new User { Id = 1 };
    //
    //     var employerDataMock = Substitute.For<IEmployerData>();
    //     var userDomainMock = Substitute.For<IUserDomain>();
    //     var userDataMock = Substitute.For<IUserData>();
    //
    //     employerDataMock.GetByIdAsync(employer.Id).Returns(Task.FromResult<Employer>(null));
    //
    //     EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
    //
    //     // Act
    //     Func<Task> act = async () => await employerDomain.UpdateAsync(employer, user, employer.Id);
    //
    //     // Assert
    //     await Assert.ThrowsAsync<InvalidUserIDException>(act);
    // }
    
    //Happy Path Delete_ValidData_ResultTrue
    [Fact]
    public async Task Delete_ValidData_ResultTrue()
    {
        // Arrange
        var employer = new Employer { Id = 1 };
        var user = new User { Id = 1 };
        
        var employerDataMock = Substitute.For<IEmployerData>();
        var userDomainMock = Substitute.For<IUserDomain>();
        var userDataMock = Substitute.For<IUserData>();

        employerDataMock.GetByIdAsync(employer.Id).Returns(Task.FromResult<Employer>(employer));
        userDomainMock.DeleteAsync(employer.UserId).Returns(true);
        userDataMock.DeleteAsync(employer.UserId).Returns(true);
        employerDataMock.DeleteAsync(employer.Id).Returns(true);
        
        EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
        var actualResult = await employerDomain.DeleteAsync(employer.Id);

        Assert.True(actualResult);
        
    }
    
    //Unhappy Path Delete_InvalidData_ThrowInvalidUserIDException
    [Fact]
    public async Task Delete_InvalidData_ThrowInvalidUserIDException()
    {
        // Arrange
        var employer = new Employer { Id = 1 };
        var user = new User { Id = 1 };
        
        var employerDataMock = Substitute.For<IEmployerData>();
        var userDomainMock = Substitute.For<IUserDomain>();
        var userDataMock = Substitute.For<IUserData>();

        employerDataMock.GetByIdAsync(employer.Id).Returns(Task.FromResult<Employer>(null));
        userDomainMock.DeleteAsync(employer.UserId).Returns(true);
        userDataMock.DeleteAsync(employer.UserId).Returns(true);
        employerDataMock.DeleteAsync(employer.Id).Returns(true);
        
        EmployerDomain employerDomain = new EmployerDomain(employerDataMock, userDomainMock, userDataMock);
        var actualResult = async () => await employerDomain.DeleteAsync(employer.Id);

        await Assert.ThrowsAsync<InvalidUserIDException>(actualResult);
        
    }


}