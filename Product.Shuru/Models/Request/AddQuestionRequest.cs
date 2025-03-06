namespace Api.Models.Request
{
    public record AddQuestionRequest
    {
        public string Description { get; set; }

        public int SurveyId { get; set; }
    }
}
