using BLL.DTO.UserDtos;
using BLL.ServiceInterfaces;
using JokrStore.API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace JokrStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly TokenHelper tokenHelper;
        private readonly IAuthService authService;

        public AuthController(TokenHelper tokenHelper, IAuthService authService)
        {
            this.tokenHelper = tokenHelper;
            this.authService = authService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            var createdUserResult = await authService.GetCreateUserResultAsync(userRegisterDto);

            if (createdUserResult.Result.Succeeded)
            {
                //TODO: egyelőre hiányzó endpoint, az mvc projektből áthozni apiba 
                return CreatedAtRoute(
                    "GetUser",
                    new { controller = "Users", id = createdUserResult.User.Id },
                    createdUserResult.User);
            }

            return BadRequest(createdUserResult.Result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var signInResult = await authService.GetSignInResultAsync(userLoginDto);

            if (signInResult.Succeeded)
            {
                return Ok(new
                {
                    token = tokenHelper.GenerateJWTToken(signInResult.User),
                    user = signInResult.User
                });
            }

            return Unauthorized();
        }
    }
}