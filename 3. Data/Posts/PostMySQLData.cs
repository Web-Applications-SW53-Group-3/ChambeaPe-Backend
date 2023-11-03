using _3._Data.Context;
using _3._Data.Model;
using Microsoft.EntityFrameworkCore;

namespace _3._Data.Posts
{
    public class PostMySQLData : IPostData
    {
        private ChambeaPeContext _context;
        public PostMySQLData(ChambeaPeContext context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAllAsync()
        {
            return await _context.Posts
                .Where(p => p.IsActive)
                .ToListAsync();
        }

        public async Task<Post?> GetByPostIdAsync(int postId)
        {
            return await _context.Posts
                .Where(p => p.IsActive && p.Id == postId)
                .FirstOrDefaultAsync();
        }

        public async Task<List<Post>> GetByEmployerIdAsync(int employerId)
        {
            return await _context.Posts
                .Where(p => p.IsActive && p.EmployerId == employerId)
                .ToListAsync();
        }

        public async Task<bool> CreateAsync(Post post, int employerId)
        {
            post.EmployerId = employerId;
            post.DateCreated = DateTime.Now;
            post.IsActive = true;
            await _context.Posts.AddAsync(post);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> UpdateAsync(Post post)
        {
            post.DateUpdated = DateTime.Now;
            post.IsActive = true;
            _context.Posts.Update(post);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteAsync(int postId)
        {
            var postToBeDeleted = await _context.Posts
                .Where(p => p.IsActive && p.Id == postId)
                .FirstOrDefaultAsync();

            if (postToBeDeleted != null)
            {
                postToBeDeleted.IsActive = false;
                _context.Posts.Update(postToBeDeleted);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}
