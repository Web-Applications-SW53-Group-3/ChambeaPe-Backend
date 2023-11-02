using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Posts;
using _3._Data.Model;
using _3._Data.Posts;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace _1._API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostData _postData;
        private readonly IPostDomain _postDomain;
        private readonly IMapper _mapper;
        private readonly ILogger<PostController> _logger;

        public PostController(IPostData postData, IPostDomain postDomain, IMapper mapper, ILogger<PostController> logger)
        {
            _postData = postData;
            _postDomain = postDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<PostController>
        /// <summary>
        /// Get all posts
        /// </summary>
        /// <returns></returns>
        [HttpGet("[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult<List<Post>>> GetAll()
        {
            try
            {
                var posts = await _postData.GetAllAsync();
                var response = _mapper.Map<List<Post>,List<PostResponse>>(posts);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET api/<PostController>/5
        /// <summary>
        /// Get a post of a employer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// <exception cref="InvalidPostIDException"></exception>
        [HttpGet("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult<Post>> GetByPostId(int id)
        {
            try
            {
                var post = await _postData.GetByPostIdAsync(id);
                if(post == null)
                {
                    throw new InvalidPostIDException($"Post ID {id} was not found");
                }
                var response = _mapper.Map<Post, PostResponse>(post);
                return Ok(response);
            }
            catch (InvalidPostIDException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET api/employer/{employerId}/post
        /// <summary>
        /// Get all posts of a employer
        /// </summary>
        /// <param name="employerId"></param>
        /// <returns></returns>
        [HttpGet("employer/{employerId}/[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult<List<Post>>> GetByEmployerId(int employerId)
        {
            try
            {
                var post = await _postData.GetByEmployerIdAsync(employerId);
                var response = _mapper.Map<List<Post>, List<PostResponse>>(post);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // POST api/<PostController>
        /// <summary>
        /// Post a new post of a employer
        /// </summary>
        /// <param name="postRequest"></param>
        /// <param name="employerId"></param>
        /// <returns></returns>
        [HttpPost("employer/{employerId}/[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult> Post([FromBody] PostRequest postRequest, int employerId)
        {
            try
            {
                var post = _mapper.Map<PostRequest, Post>(postRequest);
                await _postDomain.CreateAsync(post, employerId);
                return Ok(postRequest);
            }
            catch(DuplicatedPostException ex)
            {
                return BadRequest(new { error = "DuplicatedPost", message = ex.Message });
            }
            catch(InvalidEmployerIDException ex)
            {
                return BadRequest(new { error = "InvalidEmployerID", message = ex.Message });
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // PUT api/<PostController>/5
        /// <summary>
        /// Post a new post of a employer
        /// </summary>
        /// <param name="postRequest"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> Put([FromBody] PostRequest postRequest, int id)
        {
            try
            {
                var post = _mapper.Map<PostRequest, Post>(postRequest);
                await _postDomain.UpdateAsync(post, id);
                return Ok(postRequest);
            }
            catch (DuplicatedPostException ex)
            {
                return BadRequest(new { error = "DuplicatedPost", message = ex.Message });
            }
            catch (InvalidPostIDException ex)
            {
                return BadRequest(new { error = "InvalidPostID", message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // DELETE api/<PostController>/5
        /// <summary>
        /// Delete a post of a employer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _postDomain.DeleteAsync(id);
                return Ok($"Post with ID: {id} has been deleted successfuly");
            }
            catch (InvalidPostIDException ex)
            {
                return BadRequest(new { error = "InvalidPostID", message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
