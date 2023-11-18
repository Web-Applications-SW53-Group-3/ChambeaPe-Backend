using _1._API.Filter;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Users;
using _3._Data.Model;
using _3._Data.Users;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace _1._API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AuthorizeFilter()]
    public class UserController : ControllerBase
    {
        private IUserData _userData;
        private IUserDomain _userDomain;
        private IMapper _mapper;
        private ILogger<UserController> _logger;

        public UserController(IUserData userData, IUserDomain userDomain, IMapper mapper, ILogger<UserController> logger)
        {
            _userData = userData;
            _userDomain = userDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<UserController>
        /// <summary>
        /// Get all users 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces("application/json")]
        public async Task<ActionResult<List<UserResponse>>> GetAsync()
        {
            try
            {
                var users = await _userData.GetAllAsync();
                var response = _mapper.Map<List<User>,List<UserResponse>>(users);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
            
        }

        // GET api/<UserController>/5
        /// <summary>
        /// Get a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<ActionResult<UserResponse>> GetAsync(int id)
        {
            try
            {
                var user = await _userData.GetByIdAsync(id);
                var response = _mapper.Map<User, UserResponse>(user);
                if(user == null)
                {
                    return NotFound($"User with ID: {id} was not found");
                }
                return Ok(response);
            }catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // POST api/<UserController>
        /// <summary>
        /// Post a user
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces("application/json")]
        public async Task<ActionResult> PostAsync([FromBody] UserRequest request)
        {
            try
            {
                var user = _mapper.Map<UserRequest, User>(request);
                await _userDomain.CreateAsync(user, "-");
                return Ok(request);
            }
            catch(EmailAlreadyExistsException)
            {
                return BadRequest(new { error = "EmailAlreadyExists", message = "The email is already in use" });
            }
            catch(PhoneNumberAlreadyExistsException)
            {
                return BadRequest(new { error = "PhoneNumberAlreadyExists", message = "The phone number is already in use" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // PUT api/<UserController>/5
        /// <summary>
        /// Put a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] UserRequest request)
        {
            try
            {
                var user = _mapper.Map<UserRequest, User>(request);
                await _userDomain.UpdateAsync(user, id, "-");
                return Ok(request);
            }
            catch (EmailAlreadyExistsException)
            {
                return BadRequest(new { error = "EmailAlreadyExists", message = "The email is already in use" });
            }
            catch (PhoneNumberAlreadyExistsException)
            {
                return BadRequest(new { error = "PhoneNumberAlreadyExists", message = "The phone number is already in use" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // DELETE api/<UserController>/5
        /// <summary>
        /// Delete a user by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                await _userDomain.DeleteAsync(id);
                return Ok($"User with ID: {id} deleted successfuly");
            }
            catch(InvalidUserIDException)
            {
                return NotFound(new { error = "InvalidUserID", message = $"User ID {id} does not exist"});
            }
            catch(Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
