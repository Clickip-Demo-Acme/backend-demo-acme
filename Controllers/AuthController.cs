using Microsoft.AspNetCore.Mvc;

namespace BackendDemo.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            if (request.Username == "demo" && request.Password == "clickup")
            {
                return Ok(new { token = "fake-jwt-token-123" });
            }
            return Unauthorized();
        }
    }

    public class LoginRequest
    {
        public string Username { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
