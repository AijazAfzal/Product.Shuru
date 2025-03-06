using Api.Controllers;
using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;
using Moq;
using static Api.Models.Request.SaveSurveyRequest;

namespace Tests
{
    [TestFixture]
    public class SurveyResponseControllerTest
    {
        private Mock<ISurveyResponseRepository> _surveyResponseRepositoryMock;
        private SurveyResponseContoller _surveyResponseContoller;

        [SetUp]
        public void Setup()
        {
            _surveyResponseRepositoryMock = new Mock<ISurveyResponseRepository>();
            _surveyResponseContoller = new SurveyResponseContoller(_surveyResponseRepositoryMock.Object);
        }

        [Test]
        public async Task GetSurveyResponsesAsync_ShouldReturnOkWithSurveyResponseList()
        {
            //Arrange
            var surveyResponses = new List<SurveyResponse>
            { 
                new SurveyResponse { RespondentId = 1 , SurveyId = 1 },
                new SurveyResponse { RespondentId = 2 , SurveyId = 1 }
            };

            _surveyResponseRepositoryMock.Setup(x=>x.GetSurveyResponsesAsync()).ReturnsAsync(surveyResponses);

            //Act

            var result = await _surveyResponseContoller.GetSurveyResponsesAsync();

            //Assert

            var okResult = result as OkObjectResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
            Assert.AreEqual(surveyResponses, okResult.Value);

            var actualSurveyResponses = okResult.Value as List<SurveyResponse>;
            Assert.NotNull(actualSurveyResponses);
            Assert.AreEqual(surveyResponses.Count, actualSurveyResponses.Count);
        }

        [Test]
        public async Task SaveSurveyResponseAsync_ShouldReturnOk()
        {
            //Arrange
            var request = new SaveSurveyRequest
            {
                SurveyId= 1,
                RespondentId= 1,
                Answers = new List<SaveAnswerRequest>
                { 
                   new SaveAnswerRequest { Description = "Sample Answer 1" , QuestionId = 1 },
                   new SaveAnswerRequest { Description = "Sample Answer 2" , QuestionId = 2 }
                }
            };

            _surveyResponseRepositoryMock.Setup(x=>x.SaveSurveyResponseAsync(It.IsAny<SurveyResponse>())).Returns(Task.CompletedTask);

            //Act

            var result = await _surveyResponseContoller.SaveSurveyResponseAsync(request);

            //Assert

            var okResult = result as OkResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
    }
}
