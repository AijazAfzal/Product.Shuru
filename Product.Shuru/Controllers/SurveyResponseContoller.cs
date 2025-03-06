using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyResponseContoller : ControllerBase
    {
        private readonly ISurveyResponseRepository _surveyResponseRepository;
        public SurveyResponseContoller(ISurveyResponseRepository surveyResponseRepository)
        {
            _surveyResponseRepository = surveyResponseRepository;
        }
        [HttpGet("GetSurveyResponsesAsync")]
        public async Task<ActionResult> GetSurveyResponsesAsync() // Third Requirement (API to fetch All Survey Responses)
        {
            return Ok(await _surveyResponseRepository.GetSurveyResponsesAsync());
        }

        [HttpPost("SaveSurveyResponseAsync")]
        public async Task<ActionResult> SaveSurveyResponseAsync(SaveSurveyRequest request) // Second Requirement (API to store survey response filled by respondent)
        {
            var surveyResponse = new SurveyResponse
            {
                SurveyId = request.SurveyId,
                RespondentId = request.RespondentId,
                Answers = request.Answers?.Select(a => new Answer
                {
                    Description = a.Description,
                    QuestionId = a.QuestionId
                }).ToList() ?? new List<Answer>()
            };

            await _surveyResponseRepository.SaveSurveyResponseAsync(surveyResponse);
            return Ok();
        }
    }
}
