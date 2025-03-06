using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SurveyContoller : ControllerBase
    {
        private readonly ISurveyRepository _surveyRepository;
        public SurveyContoller(ISurveyRepository surveyRepository)
        {
            _surveyRepository = surveyRepository;
        }

        [HttpGet("GetSurveysAsync")]
        public async Task<ActionResult> GetSurveysAsync()
        {
            return Ok(await _surveyRepository.GetSurveysAsync());
        }

        [HttpPost("CreateSurveyAsync")]
        public async Task<ActionResult> CreateSurveyAsync(CreateSurveyRequest request) //First Requirement (API to create surveys)
        {
            var survey = new Survey { Name = request.Name, UserId = request.UserId };
            await _surveyRepository.CreateSurveyAsync(survey);
            return Ok();     
        }
    }
}
