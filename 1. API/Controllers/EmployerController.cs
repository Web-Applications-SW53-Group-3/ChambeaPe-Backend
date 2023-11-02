using _1._API.Request;
using _1._API.Response;
using _2._Domain.Employers;
using _2._Domain.Exceptions;
using _3._Data.Employers;
using _3._Data.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _1._API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployerController : ControllerBase
    {
        private readonly IEmployerData _employerData;
        private readonly IEmployerDomain _employerDomain;
        private readonly IMapper _mapper;
        private readonly ILogger<EmployerController> _logger;

        public EmployerController(IEmployerData employerData, IEmployerDomain employerDomain, IMapper mapper, ILogger<EmployerController> logger)
        {
            _employerData = employerData;
            _employerDomain = employerDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<EmployerController>
        /// <summary>
        /// Get all employers in the database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Produces( "application/json")]
        public async Task<ActionResult<List<Employer>>> GetAsync()
        {
            try
            {
                var employers = await _employerData.GetAllAsync();
                var response = _mapper.Map<List<Employer>, List<EmployerResponse>>(employers);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET api/<EmployerController>/5
        /// <summary>
        /// Get an employer by ID
        /// </summary>
        /// 
        [HttpGet("{id}")]
        [Produces( "application/json")]
        public async Task<ActionResult> Get(int id)
        {
            try
            {
                var employer = await _employerData.GetByIdAsync(id);
                if (employer == null)
                {
                    return NotFound($"Employer ID: {id} was not found");
                }
                var employerResponse = _mapper.Map<Employer, EmployerResponse>(employer);
                return Ok(employerResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // POST api/<EmployerController>
        /// <summary>
        /// Post a new employer
        /// </summary>
        /// <param name="employerRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Produces( "application/json")] 
        public async Task<ActionResult> Post([FromBody] EmployerRequest employerRequest)
        {
            try
            {
                var userRequest = _mapper.Map<EmployerRequest, UserRequest>(employerRequest);
                var user = _mapper.Map<UserRequest, User>(userRequest);
                var employer = _mapper.Map<EmployerRequest, Employer>(employerRequest);
                await _employerDomain.CreateAsync(employer, user);
                return Ok(employerRequest);
            }
            catch (EmailAlreadyExistsException ex)
            {
                return BadRequest(new { error = "EmailAlreadyExists", message = ex.Message });
            }
            catch (PhoneNumberAlreadyExistsException ex)
            {
                return BadRequest(new { error = "PhoneNumberAlreadyExists", message = ex.Message });
            }
            catch (UserRegistrationException ex)
            {
                return BadRequest(new { error = "UserRegistrationError", message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // PUT api/<EmployerController>/5
        /// <summary>
        /// Put an employer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="employerRequest"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [Produces( "application/json")]
        public async Task<ActionResult> Put(int id, [FromBody] EmployerRequest employerRequest)
        {
            try
            {
                var userRequest = _mapper.Map<EmployerRequest, UserRequest>(employerRequest);
                var user = _mapper.Map<UserRequest, User>(userRequest);
                var employer = _mapper.Map<EmployerRequest, Employer>(employerRequest);
                employer.User = user;

                await _employerDomain.UpdateAsync(employer, user, id);
                return Ok(employerRequest);
            }
            catch (EmailAlreadyExistsException)
            {
                return BadRequest(new { error = "EmailAlreadyExists", message = "The email is already in use" });
            }
            catch (PhoneNumberAlreadyExistsException)
            {
                return BadRequest(new { error = "PhoneNumberAlreadyExists", message = "The phone number is already in use" });
            }
            catch (InvalidUserIDException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // DELETE api/<EmployerController>/5
        /// <summary>
        /// Delete an employer by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [Produces( "application/json")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _employerDomain.DeleteAsync(id);
                return Ok($"Employer with ID: {id} deleted successfuly");
            }
            catch (InvalidUserIDException)
            {
                return NotFound(new { error = "InvalidWorkerID", message = $"Employer ID {id} does not exist" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
