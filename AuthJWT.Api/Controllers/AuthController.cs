using AuthJWT.Api.Filters;
using AuthJWT.Business.Models.Login;
using AuthJWT.Business.Models.Register;
using AuthJWT.Business.Services.Auth;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthJWT.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : Controller
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService _authService)
        {
            this.authService = _authService;
        }

        [ModelStateValidFilter]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequestModel loginRequestModel)
        {
            var response = await authService.Login(loginRequestModel);
            return response.Success ? Ok(response) : BadRequest(response);
        }

        [ModelStateValidFilter]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestModel registerRequestModel)
        {
            var response = await authService.Register(registerRequestModel);
            return response.Success ? Ok(response) : BadRequest(response);
        }
    }
}
