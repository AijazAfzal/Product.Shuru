using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RespondentController : ControllerBase
    {
        private readonly IRespondentRepository _respondentRepository;
        public RespondentController(IRespondentRepository respondentRepository)
        {
            _respondentRepository = respondentRepository;
        }
        [HttpGet("GetRespondentsAsync")]
        public async Task<ActionResult> GetRespondentsAsync()
        {
            return Ok(await _respondentRepository.GetRespondentsAsync());
        }

        [HttpPost("AddRespondentAsync")]
        public async Task<ActionResult> AddRespondentAsync(AddRespondentRequest request)
        {
            var respondent = new Respondent { Name = request.Name };
            await _respondentRepository.AddRespondentAsync(respondent);
            return Ok();
        }
    }
}
