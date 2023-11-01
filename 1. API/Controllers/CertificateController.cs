using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using _1._API.Request;
using _1._API.Response;
using _2._Domain.Certificates;
using _2._Domain.Exceptions;
using _3._Data.Certificates;
using _3._Data.Model;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace _1._API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class CertificateController : ControllerBase
    {
        private ICertificateData _certificateData;
        private ICertificateDomain _certificateDomain;
        private IMapper _mapper;
        private ILogger<CertificateController> _logger;

        public CertificateController(ICertificateData certificateData, ICertificateDomain certificateDomain, IMapper mapper, ILogger<CertificateController> logger)
        {
            _certificateData = certificateData;
            _certificateDomain = certificateDomain;
            _mapper = mapper;
            _logger = logger;
        }

        // GET: api/Certificate
        [HttpGet("[controller]")]
        public async Task<ActionResult<List<CertificateResponse>>> GetAsync()
        {
            try
            {
                var certificates = await _certificateData.GetAllAsync();
                var response = _mapper.Map<List<Certificate>, List<CertificateResponse>>(certificates);
                return Ok(response);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }

        // GET: api/Certificate/5
        [HttpGet("[controller]/{id}", Name = "GetCertificate")]
        public async Task<ActionResult<CertificateResponse>> GetAsync(int id)
        {
            try
            {
                var certificate = await _certificateData.GetByIdAsync(id);
                if (certificate == null)
                {
                    return NotFound($"Certificate ID: {id} was not found");
                }
                var certificateResponse = _mapper.Map<Certificate, CertificateResponse>(certificate);
                return Ok(certificateResponse);
            }
            catch (Exception ex)
            {
                _logger.LogError($"An error has occurred: {ex.Message}");
                return BadRequest();
            }
        }
        
        // POST: api/worker/id/certificate
        [HttpPost(template: "worker/{workerId:int}/[controller]")]
        public async Task<ActionResult> PostAsync([FromBody] CertificateRequest request, int workerId)
        {
            try
            {
                var certificate = _mapper.Map<CertificateRequest, Certificate>(request);
                bool created = await _certificateDomain.CreateAsync(certificate, workerId);
        
                if (created)
                {
                    return CreatedAtRoute("GetCertificate", new { id = certificate.Id }, _mapper.Map<Certificate, CertificateResponse>(certificate));
                }

                return BadRequest("Unable to create the certificate.");
            }
            catch (InvalidWorkerIDException)
            {
                return BadRequest(new { error = "InvalidWorkerID", message = $"The workerId {workerId} is invalid" });
            }
        }
        
        // PUT: api/Certificate/5
        [HttpPut("[controller]/{id}")]
        public async Task<ActionResult> PutAsync(int id, [FromBody] CertificateRequest request)
        {
            try
            {
                var certificate = _mapper.Map<CertificateRequest, Certificate>(request);
                bool updated = await _certificateDomain.UpdateAsync(certificate, id);
                if (updated)
                {
                    return Ok("Certificate updated successfully");
                }
                return NotFound($"Certificate ID: {id} was not found");
            }
            catch (InvalidCertificateIDException)
            {
                return NotFound(new { error = "InvalidCertificateID", message = $"The certificate ID {id} is invalid" });
            }
        }

        // DELETE: api/Certificate/5
        [HttpDelete("[controller]/{id}")]
        public async Task<ActionResult> DeleteAsync(int id)
        {
            try
            {
                bool deleted = await _certificateDomain.DeleteAsync(id);
                if (deleted)
                {
                    return Ok("Certificate deleted successfully");
                }
                return NotFound($"Certificate ID: {id} was not found");
            }
            catch (InvalidCertificateIDException)
            {
                return NotFound(new { error = "InvalidCertificateID", message = $"The certificate ID {id} is invalid" });
            }
        }
    }
}
