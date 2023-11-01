using _1._API.Request;
using _1._API.Response;
using _2._Domain.Advertisements;
using _2._Domain.Exceptions;
using _3._Data.Advertisements;
using _3._Data.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _1._API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class AdvertisementController : ControllerBase
    {
        private IAdvertisementData _advertisementData;
        private IAdvertisementDomain _advertisementDomain;
        private IMapper _mapper;
        private ILogger<AdvertisementController> _logger;

        public AdvertisementController(IAdvertisementData advertisementData, IAdvertisementDomain advertisementDomain, IMapper mapper, ILogger<AdvertisementController> logger)
        {
            _advertisementData = advertisementData;
            _advertisementDomain = advertisementDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Advertisement
        [HttpGet("[controller]")]
        public async Task<ActionResult<List<AdvertisementResponse>>> GetAsync()
        {
            try
            {
                var advertisements = await _advertisementData.GetAllAsync();
                var response = _mapper.Map<List<Advertisement>, List<AdvertisementResponse>>(advertisements);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET: api/Advertisement/5
        [HttpGet("[controller]/{id}", Name = "GetAdvertisement")]
        public async Task<ActionResult<AdvertisementResponse>> GetAsync(int id)
        {
            try
            {
                var advertisement = await _advertisementData.GetByIdAsync(id);
                if (advertisement == null)
                {
                    return NotFound($"Advertisement ID: {id} was not found");
                }
                var advertisementResponse = _mapper.Map<Advertisement, AdvertisementResponse>(advertisement);
                return Ok(advertisementResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // POST: api/worker/id/advertisement
        [HttpPost(template: "worker/{workerId:int}/[controller]")]
        public async Task<ActionResult> PostAsync([FromBody] AdvertisementRequest request, int workerId)
        {
            try
            {
                var advertisement = _mapper.Map<AdvertisementRequest, Advertisement>(request);
                bool created = await _advertisementDomain.CreateAsync(advertisement, workerId);
                if (created)
                {
                    return CreatedAtRoute("GetAdvertisement", new { id = advertisement.Id }, _mapper.Map<Advertisement, AdvertisementResponse>(advertisement));
                }
                return BadRequest("Unable to create the advertisement.");
            }
            catch (InvalidWorkerIDException)
            {
                return BadRequest(new { error = "InvalidWorkerID", message = $"The workerId {workerId} is invalid" });
            }
        }

        // PUT: api/Advertisement/5
        [HttpPut("[controller]/{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] AdvertisementRequest request)
        {
            try
            {
                var advertisement = _mapper.Map<AdvertisementRequest, Advertisement>(request);
                bool updated = await _advertisementDomain.UpdateAsync(advertisement, id);
                if (updated)
                {
                    return Ok("Advertisement updated successfully");
                }
                return NotFound($"Advertisement ID: {id} was not found");
            }
            catch (InvalidAdvertisementIDException)
            {
                return NotFound(new { error = "InvalidAdvertisementID", message = $"The advertisement ID {id} is invalid" });
            }
        }

        // DELETE: api/Advertisement/5
        [HttpDelete("[controller]/{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                bool deleted = await _advertisementDomain.DeleteAsync(id);
                if (deleted)
                {
                    return Ok("Advertisement deleted successfully");
                }
                return NotFound($"Advertisement ID: {id} was not found");
            }
            catch (InvalidAdvertisementIDException)
            {
                return NotFound(new { error = "InvalidAdvertisementID", message = $"The advertisement ID {id} is invalid" });
            }
        }
    }
}
