using _3._Data.Model;

namespace _3._Data.Posts
{
    public interface IPostData
    {
        public Task<List<Post>> GetAllAsync();

        public Task<Post?> GetByPostIdAsync(int postId);

        public Task<List<Post>> GetByEmployerIdAsync(int employerId);

        public Task<bool> CreateAsync(Post post, int employerId);

        public Task<bool> UpdateAsync(Post post);

        public Task<bool> DeleteAsync(int postId);
    }
}
