using Microsoft.AspNetCore.Mvc;
using _1._API.Response;
using AutoMapper;
using _3._Data.Model;
using _3._Data.Workers;
using _2._Domain.Workers;
using _1._API.Request;
using _2._Domain.Exceptions;

namespace _1._API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkerController : ControllerBase
    {
        private readonly IWorkerData _workerData;
        private readonly IWorkerDomain _workerDomain;
        private readonly IMapper _mapper;
        private readonly ILogger<WorkerController> _logger;
        public WorkerController(IWorkerData workerData, IWorkerDomain workerDomain, IMapper mapper, ILogger<WorkerController> logger)
        {
            _workerData = workerData;
            _workerDomain = workerDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/<WorkerController>
        [HttpGet]
        public async Task<ActionResult<List<WorkerResponse>>> GetAsync()
        {
            try
            {
                var workers = await _workerData.GetAllAsync();
                var response = _mapper.Map<List<Worker>,List<WorkerResponse>>(workers);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET api/<WorkerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkerResponse>> Get(int id)
        {
            try
            {
                var worker = await _workerData.GetByIdAsync(id);
                if (worker == null)
                {
                    return NotFound($"Worker ID: {id} was not found");
                }
                var workerResponse = _mapper.Map<Worker, WorkerResponse>(worker);
                return Ok(workerResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
            
        }

        // POST api/<WorkerController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] WorkerRequest workerRequest)
        {
            try
            {
                var userRequest = _mapper.Map<WorkerRequest, UserRequest>(workerRequest);
                var user = _mapper.Map<UserRequest, User>(userRequest);
                var worker = _mapper.Map<WorkerRequest, Worker>(workerRequest);
                await _workerDomain.CreateAsync(worker, user);
                return Ok(workerRequest);
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

        // PUT api/<WorkerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] WorkerRequest workerRequest)
        {
            try
            {
                var userRequest = _mapper.Map<WorkerRequest, UserRequest>(workerRequest);
                var user = _mapper.Map<UserRequest, User>(userRequest);
                var worker = _mapper.Map<WorkerRequest, Worker>(workerRequest);
                worker.User = user;

                await _workerDomain.UpdateAsync(worker, user, id);
                return Ok(workerRequest);
            }
            catch (EmailAlreadyExistsException)
            {
                return BadRequest(new { error = "EmailAlreadyExists", message = "The email is already in use" });
            }
            catch (PhoneNumberAlreadyExistsException)
            {
                return BadRequest(new { error = "PhoneNumberAlreadyExists", message = "The phone number is already in use" });
            }
            catch(InvalidUserIDException)
            {
                return NotFound();
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();     
            }
        }

        // DELETE api/<WorkerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _workerDomain.DeleteAsync(id);
                return Ok($"Worker with ID: {id} deleted successfuly");
            }
            catch (InvalidUserIDException)
            {
                return NotFound(new { error = "InvalidWorkerID", message = $"Worker ID {id} does not exist" });
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has ocurred: {ex.Message}");
                return BadRequest();
            }
        }
    }
}
