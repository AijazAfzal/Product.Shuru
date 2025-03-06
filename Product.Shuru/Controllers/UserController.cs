using Api.Models.Request;
using Domain.Entity;
using Domain.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet("GetUsersAsync")]
        public async Task<ActionResult> GetUsersAsync()
        {
            return Ok(await _userRepository.GetUsersAsync());
        }

        [HttpPost("AddUserAsync")]
        public async Task<ActionResult> AddUserAsync(AddUserRequest request)
        {
            var user = new User { Name = request.Name, Email = request.Email };
            await _userRepository.AddUserAync(user);
            return Ok();
        }
    }
}
