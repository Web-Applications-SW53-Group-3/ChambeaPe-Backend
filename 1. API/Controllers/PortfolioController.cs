using _1._API.Request;
using _1._API.Response;
using _2._Domain.Exceptions;
using _2._Domain.Portfolios;
using _3._Data.Model;
using _3._Data.Portfolios;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;


namespace _1._API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class PortfolioController : ControllerBase
    {
        private IPortfolioData _portfolioData;
        private IPortfolioDomain _portfolioDomain;
        private IMapper _mapper;
        private ILogger<PortfolioController> _logger;

        public PortfolioController(IPortfolioData portfolioData, IPortfolioDomain portfolioDomain, IMapper mapper, ILogger<PortfolioController> logger)
        {
            _portfolioData = portfolioData;
            _portfolioDomain = portfolioDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Portfolio
        /// <summary>
        /// Get all portfolios of a worker
        /// </summary>
        /// <returns></returns>
        [HttpGet("[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult<List<PortfolioResponse>>> GetAsync()
        {
            try
            {
                var portfolios = await _portfolioData.GetAllAsync();
                var response = _mapper.Map<List<Portfolio>, List<PortfolioResponse>>(portfolios);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET: api/Portfolio/5
        /// <summary>
        /// Get a portfolio by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("[controller]/{id}", Name = "GetPortfolio")]
        [Produces("application/json")]
        public async Task<ActionResult<PortfolioResponse>> GetAsync(int id)
        {
            try
            {
                var portfolio = await _portfolioData.GetByIdAsync(id);
                if (portfolio == null)
                {
                    return NotFound($"Portfolio ID: {id} was not found");
                }
                var portfolioResponse = _mapper.Map<Portfolio, PortfolioResponse>(portfolio);
                return Ok(portfolioResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // POST: api/worker/id/portfolio
        /// <summary>
        /// Post a new portfolio of a worker
        /// </summary>
        /// <param name="request"></param>
        /// <param name="workerId"></param>
        /// <returns></returns>
        [HttpPost(template: "worker/{workerId:int}/[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult> PostAsync([FromBody] PortfolioRequest request, int workerId)
        {
            try
            {
                var portfolio = _mapper.Map<PortfolioRequest, Portfolio>(request);
                bool created = await _portfolioDomain.CreateAsync(portfolio, workerId);

                if (created)
                {
                    return CreatedAtRoute("GetPortfolio", new { id = portfolio.Id }, _mapper.Map<Portfolio, PortfolioResponse>(portfolio));
                }

                return BadRequest("Unable to create the portfolio.");
            }
            catch (InvalidWorkerIDException)
            {
                return BadRequest(new { error = "InvalidWorkerID", message = $"The workerId {workerId} is invalid" });
            }
        }

        // PUT: api/Portfolio/5
        /// <summary>
        /// Put a portfolio of a worker by ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] PortfolioRequest request)
        {
            try
            {
                var portfolio = _mapper.Map<PortfolioRequest, Portfolio>(request);
                bool updated = await _portfolioDomain.UpdateAsync(portfolio, id);
                if (updated)
                {
                    return Ok("Portfolio updated successfully");
                }
                return NotFound($"Portfolio ID: {id} was not found");
            }
            catch (InvalidPortfolioIDException)
            {
                return NotFound(new { error = "InvalidPortfolioID", message = $"The portfolio ID {id} is invalid" });
            }
        }

        // DELETE: api/Portfolio/5
        /// <summary>
        /// Delete a portfolio of a worker by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                bool deleted = await _portfolioDomain.DeleteAsync(id);
                if (deleted)
                {
                    return Ok("Portfolio deleted successfully");
                }
                return NotFound($"Portfolio ID: {id} was not found");
            }
            catch (InvalidPortfolioIDException)
            {
                return NotFound(new { error = "InvalidPortfolioID", message = $"The portfolio ID {id} is invalid" });
            }
        }
    }
}
