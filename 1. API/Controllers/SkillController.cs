using _1._API.Request;
using _1._API.Response;
using _2._Domain.Skills;
using _2._Domain.Exceptions;
using _3._Data.Skills;
using _3._Data.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace _1._API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class SkillController : ControllerBase
    {
        private ISkillData _skillData;
        private ISkillDomain _skillDomain;
        private IMapper _mapper;
        private ILogger<SkillController> _logger;

        public SkillController(ISkillData skillData, ISkillDomain skillDomain, IMapper mapper, ILogger<SkillController> logger)
        {
            _skillData = skillData;
            _skillDomain = skillDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Skill
        /// <summary>
        /// Get all skills of the chambeador
        /// </summary>
        /// <returns></returns>
        [HttpGet("[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult<List<SkillResponse>>> GetAsync()
        {
            try
            {
                var skills = await _skillData.GetAllAsync();
                var response = _mapper.Map<List<Skill>, List<SkillResponse>>(skills);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET: api/Skill/5
        /// <summary>
        /// Get a skill of a chambeador by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("[controller]/{id}", Name = "GetSkill")]
        [Produces("application/json")]
        public async Task<ActionResult<SkillResponse>> GetAsync(int id)
        {
            try
            {
                var skill = await _skillData.GetByIdAsync(id);
                if (skill == null)
                {
                    return NotFound($"Skill ID: {id} was not found");
                }
                var skillResponse = _mapper.Map<Skill, SkillResponse>(skill);
                return Ok(skillResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // POST: api/worker/id/skill
        /// <summary>
        /// Post a skill of a chambeador 
        /// </summary>
        /// <param name="request"></param>
        /// <param name="workerId"></param>
        /// <returns></returns>
        [HttpPost(template: "worker/{workerId:int}/[controller]")]
        [Produces("application/json")]
        public async Task<ActionResult> PostAsync([FromBody] SkillRequest request, int workerId)
        {
            try
            {
                var skill = _mapper.Map<SkillRequest, Skill>(request);
                bool created = await _skillDomain.CreateAsync(skill, workerId);
                if (created)
                {
                    return CreatedAtRoute("GetSkill", new { id = skill.Id }, _mapper.Map<Skill, SkillResponse>(skill));
                }
                return BadRequest("Unable to create the skill.");
            }
            catch (InvalidWorkerIDException)
            {
                return BadRequest(new { error = "InvalidWorkerID", message = $"The workerId {workerId} is invalid" });
            }
        }

        // PUT: api/Skill/5
        /// <summary>
        /// Put a skill of a chambeador by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPut("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] SkillRequest request)
        {
            try
            {
                var skill = _mapper.Map<SkillRequest, Skill>(request);
                bool updated = await _skillDomain.UpdateAsync(skill, id);
                if (updated)
                {
                    return Ok("Skill updated successfully");
                }
                return NotFound($"Skill ID: {id} was not found");
            }
            catch (InvalidSkillIDException)
            {
                return NotFound(new { error = "InvalidSkillID", message = $"The skill ID {id} is invalid" });
            }
        }

        // DELETE: api/Skill/5
        /// <summary>
        /// Delete a skill of a chambeador by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("[controller]/{id}")]
        [Produces("application/json")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                bool deleted = await _skillDomain.DeleteAsync(id);
                if (deleted)
                {
                    return Ok("Skill deleted successfully");
                }
                return NotFound($"Skill ID: {id} was not found");
            }
            catch (InvalidSkillIDException)
            {
                return NotFound(new { error = "InvalidSkillID", message = $"The skill ID {id} is invalid" });
            }
        }
    }
}
