using JC.BusinessLogic.Contracts.Managers;
using JC.BusinessObject.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JC.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateManager _candidateManager;
        private readonly ILogger _logger;

        public CandidateController(ICandidateManager candidateManager, ILogger<Candidate> logger)
        {
            _candidateManager = candidateManager;
            _logger = logger;
        }
        [HttpPost]
        public async Task<IActionResult> Save(Candidate candidate)
        {
            try
            {
                await _candidateManager.SaveAsync(candidate);
                _logger.LogInformation($"Candidate {candidate.FirstName} {candidate.LastName} is Saved");
                return Ok();
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.ToString());
                return BadRequest("Sorry we are not able to Save Data, Please Try Again");
            }
        }
    }
}
