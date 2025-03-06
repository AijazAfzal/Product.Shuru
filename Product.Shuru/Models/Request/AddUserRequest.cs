namespace Api.Models.Request
{
    public record AddUserRequest
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
