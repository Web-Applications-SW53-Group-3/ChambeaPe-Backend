using _2._Domain.Certificates;
using _2._Domain.Exceptions;
using _2._Domain.Workers;
using _3._Data.Certificates;
using _3._Data.Model;
using _3._Data.Workers;
using NSubstitute;

namespace _2._Domain.Tests.CertificatesTests;

public class CertificateDomainTest
{
    //Todo: Happy Path CreateAsync
    [Fact]
    public async Task CreateAsync_ValidData_ResultTrue()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };
        Worker worker = new Worker()
        {
            Id = 1,
        };
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        workerDomainMock.ExistsByWorkerId(certificate.WorkerId).Returns(true);
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(null));
        certificateDataMock.CreateAsync(certificate).Returns(true);
        workerDataMock.GetByIdAsync(certificate.WorkerId)!.Returns(Task.FromResult(worker));
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = await certificateDomain.CreateAsync(certificate, certificate.WorkerId);

        //Assert
        Assert.True(actualResult);
    }
    
    //unhappy path duplicatedCertificate
    [Fact]
    public async Task CreateAsync_DuplicatedCertificate_ThrowDuplicatedCertificateIDException()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };
        Worker worker = new Worker()
        {
            Id = 1,
        };
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        certificateDataMock.GetByCertificateIdAsync(certificate.CertificateId)!.Returns(Task.FromResult<Certificate>(certificate));
        workerDomainMock.ExistsByWorkerId(certificate.WorkerId).Returns(true);
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(certificate));
        certificateDataMock.CreateAsync(certificate).Returns(true);
        workerDataMock.GetByIdAsync(certificate.WorkerId)!.Returns(Task.FromResult(worker));
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = async () => await certificateDomain.CreateAsync(certificate, certificate.Id);
        
        //Assert
        await Assert.ThrowsAsync<DuplicatedCertificateIDException>(actualResult);
    }
    
    
    //happy path UpdateAsync
    [Fact]
    public async Task UpdateAsync_ValidData_ResultTrue()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };
        Worker worker = new Worker()
        {
            Id = 1,
        };
        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(certificate));
        certificateDataMock.UpdateAsync(certificate, certificate.Id).Returns(true);
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = await certificateDomain.UpdateAsync(certificate, certificate.Id);

        //Assert
        Assert.True(actualResult);
    }
    
    //Unhappy Path UpdateAsync
    [Fact]
    public async Task UpdateAsync_InvalidCertificateID_ThrowInvalidCertificateIDException()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };

        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(null));
        certificateDataMock.UpdateAsync(certificate, certificate.Id).Returns(true);
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = async () => await certificateDomain.UpdateAsync(certificate, certificate.Id);
        
        //Assert
        await Assert.ThrowsAsync<InvalidCertificateIDException>(actualResult);
    }
    
    //Happy Path DeleteAsync
    [Fact]
    public async Task DeleteAsync_ValidData_ResultTrue()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };

        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(certificate));
        certificateDataMock.DeleteAsync(certificate.Id).Returns(true);
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = await certificateDomain.DeleteAsync(certificate.Id);

        //Assert
        Assert.True(actualResult);
    }
    
    //Unhappy Path DeleteAsync
    [Fact]
    public async Task DeleteAsync_InvalidCertificateID_ThrowInvalidCertificateIDException()
    {
        //Arrange
        Certificate certificate = new Certificate()
        {
            CertificateId = "1",
        };

        var workerDataMock = Substitute.For<IWorkerData>();
        var workerDomainMock = Substitute.For<IWorkerDomain>();
        var certificateDataMock = Substitute.For<ICertificateData>();
        certificateDataMock.GetByIdAsync(certificate.Id)!.Returns(Task.FromResult<Certificate>(null));
        certificateDataMock.DeleteAsync(certificate.Id).Returns(true);
        
        //Act
        CertificateDomain certificateDomain = new CertificateDomain(certificateDataMock, workerDomainMock, workerDataMock);
        var actualResult = async () => await certificateDomain.DeleteAsync(certificate.Id);
        
        //Assert
        await Assert.ThrowsAsync<InvalidCertificateIDException>(actualResult);
    }

}