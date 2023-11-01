using _2._Domain.Advertisements;
using _2._Domain.Exceptions;
using _2._Domain.Workers;
using _3._Data.Advertisements;
using _3._Data.Model;
using _3._Data.Workers;
using NSubstitute;

namespace _2._Domain.Tests.AdvertisementsTests;

public class AdvertisementDomainTest
{
    //Todo: happy path 
    [Fact]
    public async Task Create_ValidData_ResultTrue()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            WorkerId = 1
        };
        Worker worker = new Worker()
        {
            Id = 1,
        };
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        workerDomainMock.ExistsByWorkerId(advertisement.WorkerId).Returns(true);
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(null));
        advertisementDataMock.CreateAsync(advertisement).Returns(true);
        workerDataMock.GetByIdAsync(advertisement.WorkerId).Returns(Task.FromResult(worker));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, workerDomainMock, workerDataMock);
        var actualResult = await advertisementDomain.CreateAsync(advertisement, advertisement.WorkerId);

        //Assert
        Assert.True(actualResult);
    }
    //Todo: unhappy path worker doesn't exist
    [Fact]
    public async Task Create_InvalidDataWorkerDoesntExist_ResultFalse()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            WorkerId = 1
        };
        Worker worker = new Worker()
        {
            Id = 1,
        };
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        workerDomainMock.ExistsByWorkerId(advertisement.WorkerId).Returns(false);
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(null));
        advertisementDataMock.CreateAsync(advertisement).Returns(true);
        workerDataMock.GetByIdAsync(advertisement.WorkerId).Returns(Task.FromResult(worker));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, workerDomainMock, workerDataMock);
        var actualResult = await advertisementDomain.CreateAsync(advertisement, advertisement.WorkerId);

        //Assert
        Assert.False(actualResult);
    }
    
    //Todo: HappyPath UpdateAsync
    [Fact]
    public async Task UpdateAsync_ValidData_ReturnTrue()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            Id = 1,
        };
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(advertisement));
        advertisementDataMock.UpdateAsync(advertisement, advertisement.Id).Returns(Task.FromResult(true));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, workerDomainMock, workerDataMock);
        var actualResult = await advertisementDomain.UpdateAsync(advertisement, advertisement.Id);
        
        //Assert
        Assert.True(actualResult);
    }
    
    //Todo: UnhappyPath UpdateAsync
    [Fact]
    public async Task UpdateAsync_InvalidData_ThowInvalidAdvertisementIDException()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            Id = 1,
        };
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(null));
        advertisementDataMock.UpdateAsync(advertisement, advertisement.Id).Returns(Task.FromResult(true));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, null, null);
        var actualResult = async () => await advertisementDomain.UpdateAsync(advertisement, advertisement.Id);
        
        //Assert
        await Assert.ThrowsAsync<InvalidAdvertisementIDException>(actualResult);
    }
    
    //Todo: HappyPath DeleteAsync
    [Fact]
    public async Task DeleteAsync_ValidData_ReturnTrue()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            Id = 1,
        };
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(advertisement));
        advertisementDataMock.DeleteAsync(advertisement.Id).Returns(Task.FromResult(true));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, workerDomainMock, workerDataMock);
        var actualResult = await advertisementDomain.DeleteAsync(advertisement.Id);
        
        //Assert
        Assert.True(actualResult);
    }
    
    //Todo: UnhappyPath DeleteAsync
    [Fact]
    public async Task DeleteAsync_InvalidData_ThowInvalidAdvertisementIDException()
    {
        //Arrange
        Advertisement advertisement = new Advertisement()
        {
            Id = 1,
        };
        var advertisementDataMock = Substitute.For<IAdvertisementData>();
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        advertisementDataMock.GetByIdAsync(advertisement.Id).Returns(Task.FromResult<Advertisement>(null));
        advertisementDataMock.DeleteAsync(advertisement.Id).Returns(Task.FromResult(true));
        
        //Act
        AdvertisementDomain advertisementDomain = new AdvertisementDomain(advertisementDataMock, workerDomainMock, workerDataMock);
        var actualResult = async () => await advertisementDomain.DeleteAsync(advertisement.Id);
        
        //Assert
        await Assert.ThrowsAsync<InvalidAdvertisementIDException>(actualResult);
    }
    
}