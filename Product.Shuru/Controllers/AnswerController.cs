using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly IAnswerRepository _answerRepository;
        public AnswerController(IAnswerRepository answerRepository)
        {
            _answerRepository = answerRepository;
        }

        [HttpGet("GetAnswersAsync")]
        public async Task<ActionResult> GetAnswersAsync()
        {
            return Ok(await _answerRepository.GetAnswersAsync());
        }

        [HttpPost("PostAnswerAsync")]
        public  async Task<ActionResult> PostAnswerAsync(PostAnswerRequest request)
        {
            var answer = new Answer { Description = request.Description, QuestionId = request.QuestionId, SurveyResponseId = request.SurveyResponseId };
            await _answerRepository.PostAnswerAsync(answer);
            return Ok();
        }
    }
}
