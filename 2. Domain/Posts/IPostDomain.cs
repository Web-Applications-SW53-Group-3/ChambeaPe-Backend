using _3._Data.Model;

namespace _2._Domain.Posts
{
    public interface IPostDomain
    {
        public Task<bool> CreateAsync(Post post, int employerId);
        public Task<bool> UpdateAsync(Post post, int postId);
        public Task<bool> DeleteAsync(int postId);
    }
}
