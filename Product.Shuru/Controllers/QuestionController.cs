using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        private readonly IQuestionRepository _questionRepository;
        public QuestionController(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        [HttpGet("GetQuestionsAsync")]
        public async Task<ActionResult> GetQuestionsAsync()
        {
            return Ok (await _questionRepository.GetQuestionsAsync());
        }

        
        [HttpPost("AddQuestionAsync")]
        public async Task<ActionResult> AddQuestionAsync(AddQuestionRequest request)
        {
            var question = new Question { Description = request.Description, SurveyId = request.SurveyId };
            await _questionRepository.AddQuestionAsync(question);
            return Ok ();
        }
    }
}
