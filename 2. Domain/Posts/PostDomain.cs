using _2._Domain.Exceptions;
using _3._Data.Employers;
using _3._Data.Model;
using _3._Data.Posts;
using AutoMapper;

namespace _2._Domain.Posts
{
    public class PostDomain : IPostDomain
    {
        private IPostData _postData;
        private IMapper _mapper;
        private IEmployerData _employerData;

        public PostDomain(IPostData postData, IMapper mapper, IEmployerData employerData)
        {
            _postData = postData;
            _mapper = mapper;
            _employerData = employerData;
        }

        public async Task<bool> CreateAsync(Post newPost, int employerId)
        {
            Employer employer = await _employerData.GetByIdAsync(employerId);

            if (employer == null)
            {
                throw new InvalidEmployerIDException($"Employer with ID {employerId} was NOT found");
            }

            List<Post> posts = await _postData.GetByEmployerIdAsync(employerId);
            
            foreach (Post post in posts) {
                if(post.Title == newPost.Title)
                {
                    throw new DuplicatedPostException("A post with this title already exists");
                }
            }

            await _postData.CreateAsync(newPost, employerId);
            return true;
        }

        public async Task<bool> UpdateAsync(Post post, int postId)
        {
            var postToBeUpdated = await _postData.GetByPostIdAsync(postId);

            if (postToBeUpdated == null) 
            { 
                throw new InvalidPostIDException($"Post with ID {postId} was NOT found");
            }

            if(postToBeUpdated.Title == post.Title && postToBeUpdated.Id != postId)
            {
                throw new DuplicatedPostException("A post with this title already exists");
            }

            postToBeUpdated.Title = post.Title;
            postToBeUpdated.Subtitle = post.Subtitle;
            postToBeUpdated.Description = post.Description;
            postToBeUpdated.ImgUrl = post.ImgUrl;

            await _postData.UpdateAsync(postToBeUpdated);
            return true;
        }

        public async Task<bool> DeleteAsync(int postId)
        {
            var postDeleted = await _postData.DeleteAsync(postId);
            if (!postDeleted)
            {
                throw new InvalidPostIDException($"Post ID {postId} was NOT found");
            }
            return true;
        }
    }
}
