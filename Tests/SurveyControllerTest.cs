using Api.Controllers;
using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace Tests
{
    [TestFixture]
    public class SurveyControllerTest
    {
        private Mock<ISurveyRepository> _surveyRepositoryMock;
        private SurveyContoller _surveyContoller; 

        [SetUp]
        public void Setup()
        {
            _surveyRepositoryMock = new Mock<ISurveyRepository>();
            _surveyContoller = new SurveyContoller( _surveyRepositoryMock.Object );
        }

        [Test]
        public async Task CreateSurveyAsync_ShouldReturnOk()
        {
            // Arrange
            var request = new CreateSurveyRequest
            {
                Name = "Sample Survey",
                UserId = 1
            };

            _surveyRepositoryMock.Setup(x=>x.CreateSurveyAsync(It.IsAny<Survey>())).Returns(Task.CompletedTask);


            // Act

            var result = await _surveyContoller.CreateSurveyAsync(request);

            // Assert

            var okResult = result as OkResult;
            Assert.NotNull(okResult);
            Assert.AreEqual(200, okResult.StatusCode);
        }
}   }
