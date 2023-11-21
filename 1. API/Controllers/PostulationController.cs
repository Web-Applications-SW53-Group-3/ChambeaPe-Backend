using _1._API.Filter;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Postulations;
using _3._Data.Model;
using _3._Data.Postulations;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace _1._API.Controllers
{
    [Route("api")]
    [ApiController]
    public class PostulationController : ControllerBase
    {
        private readonly IPostulationData _postulationData;
        private readonly IPostulationDomain _postulationDomain;
        private readonly IMapper _mapper;
        private readonly ILogger<PostulationController> _logger;

        public PostulationController(IPostulationData postulationData, IPostulationDomain postulationDomain, IMapper mapper, ILogger<PostulationController> logger)
        {
            _postulationData = postulationData;
            _postulationDomain = postulationDomain;
            _mapper = mapper;
            _logger = logger;
        }
        // GET: api/<PostulationController>
        [HttpGet("posts/{postId}/[controller]")]
        [AuthorizeFilter("E")]
        public async Task<ActionResult<List<PostulationResponse>>> GetAllByPostIdAsync(int postId)
        {
            try
            {
                var postulation = await _postulationData.GetAllByPostIdAsync(postId);
                var response = _mapper.Map<List<Postulation>,List<PostulationResponse>>(postulation);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET: api/<PostulationController>
        [HttpGet("workers/{workerId}/[controller]")]
        [AuthorizeFilter("W")]
        public async Task<ActionResult<List<PostulationResponse>>> GetAllByWorkerIdAsync(int workerId)
        {
            try
            {
                var postulation = await _postulationData.GetAllByWorkerIdAsync(workerId);
                var response = _mapper.Map<List<Postulation>, List<PostulationResponse>>(postulation);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // GET api/<PostulationController>/5
        [HttpGet("[controller]/{id}")]
        public async Task<ActionResult<PostulationResponse>> GetById(int id)
        {
            try
            {
                var postulation = await _postulationData.GetByIdAsync(id);
                var response = _mapper.Map<Postulation, PostulationResponse>(postulation);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // POST api/<PostulationController>
        [AuthorizeFilter("W")]
        [HttpPost("[controller]")]
        public async Task<ActionResult> Post([FromBody] PostulationRequest postulationRequest)
        {
            try
            {
                var postulation = _mapper.Map<PostulationRequest, Postulation>(postulationRequest);
                await _postulationDomain.CreateAsync(postulation);
                return Ok(postulationRequest);
            }
            catch (InvalidWorkerIDException ex)
            {
                return BadRequest(new { error = "InvalidWorkerID", message = ex.Message });
            }
            catch (InvalidPostIDException ex)
            {
                return BadRequest(new { error = "InvalidPostID", message = ex.Message });
            }
            catch (AlreadyPostulatedException ex)
            {
                return BadRequest(new {error = "AlreadyApplied", message = ex.Message});
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }

        // DELETE api/<PostulationController>/5
        [AuthorizeFilter()]
        [HttpDelete("[controller]/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await _postulationDomain.DeleteAsync(id);
                return Ok($"Postulation with ID: {id} has been deleted successfuly");
            }
            catch (InvalidPostulationIDException ex)
            {
                return BadRequest(new { error = "InvalidPostulationID", message = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest();
            }
        }
    }
}
