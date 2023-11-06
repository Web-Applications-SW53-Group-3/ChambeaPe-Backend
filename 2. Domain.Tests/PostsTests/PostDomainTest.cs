using System.Threading.Tasks;
using Xunit;
using _2._Domain.Posts;
using _3._Data.Model;
using _3._Data.Employers;
using AutoMapper;
using NSubstitute;
using _2._Domain.Exceptions;
using _3._Data.Posts;

public class PostDomainTests
{
    // Happy Path: CreateAsync
    [Fact]
    public async Task CreateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        var postDataMock = Substitute.For<IPostData>();
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();

        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);

        var newPost = new Post();
        var employerId = 1;

        employerDataMock.GetByIdAsync(employerId).Returns(Task.FromResult(new Employer()));

        postDataMock.GetByEmployerIdAsync(employerId).Returns(Task.FromResult(new List<Post>()));
        postDataMock.CreateAsync(Arg.Any<Post>(), employerId).Returns(true);

        // Act
        var result = await postDomain.CreateAsync(newPost, employerId);

        // Assert
        Assert.True(result);
    }

    // Unhappy Path: CreateAsync - Invalid Employer
    [Fact]
    public async Task CreateAsync_InvalidEmployer_ThrowsException()
    {
        // Arrange
        var postDataMock = Substitute.For<IPostData>();
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();

        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);

        var newPost = new Post();
        var employerId = 1;

        employerDataMock.GetByIdAsync(employerId).Returns(Task.FromResult((Employer)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidEmployerIDException>(async () =>
        {
            await postDomain.CreateAsync(newPost, employerId);
        });
    }

    // Happy Path: UpdateAsync
    [Fact]
    public async Task UpdateAsync_ValidData_ReturnsTrue()
    {
        // Arrange
        Post postTobeUpdated = new Post()
        {
            Id = 1,
            Title = "Title",
            Subtitle = "Subtitle",
            Description = "Description"
        };
        Post post = new Post()
        {
            Id = 1,
            Title = "Title2",
            Subtitle = "Subtitle2",
            Description = "Description2"
        };
        var postDataMock = Substitute.For<IPostData>();
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();
        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);
        
        postDataMock.GetByPostIdAsync(postTobeUpdated.Id).Returns(Task.FromResult(post));
        postDataMock.UpdateAsync(postTobeUpdated).Returns(true);

        // Act
        var result = await postDomain.UpdateAsync(postTobeUpdated, postTobeUpdated.Id);

        // Assert
        Assert.True(result);
    }

    // Unhappy Path: UpdateAsync - Invalid Post
    [Fact]
    public async Task UpdateAsync_InvalidPost_ThrowsException()
    {
        // Arrange
        var postDataMock = Substitute.For<IPostData>();
        
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();

        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);

        var postToUpdate = new Post();
        var postId = 1;

        postDataMock.GetByPostIdAsync(postId).Returns(Task.FromResult((Post)null));

        // Act and Assert
        await Assert.ThrowsAsync<InvalidPostIDException>(async () =>
        {
            await postDomain.UpdateAsync(postToUpdate, postId);
        });
    }

    // Happy Path: DeleteAsync
    [Fact]
    public async Task DeleteAsync_ValidPostId_ReturnsTrue()
    {
        // Arrange
        var postDataMock = Substitute.For<IPostData>();
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();

        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);

        var postId = 1;

        postDataMock.DeleteAsync(postId).Returns(true);

        // Act
        var result = await postDomain.DeleteAsync(postId);

        // Assert
        Assert.True(result);
    }

    // Unhappy Path: DeleteAsync - Invalid Post
    [Fact]
    public async Task DeleteAsync_InvalidPost_ThrowsException()
    {
        // Arrange
        var postDataMock = Substitute.For<IPostData>();
        var employerDataMock = Substitute.For<IEmployerData>();
        var mapper = Substitute.For<IMapper>();

        var postDomain = new PostDomain(postDataMock, mapper, employerDataMock);

        var postId = 1;

        postDataMock.DeleteAsync(postId).Returns(false);

        // Act and Assert
        await Assert.ThrowsAsync<InvalidPostIDException>(async () =>
        {
            await postDomain.DeleteAsync(postId);
        });
    }
}
