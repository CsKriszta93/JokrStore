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
            var createdUser = await authService.CreateUserAsync(userRegisterDto);

            if (createdUser.Id != null)
            {
                //TODO: egyelőre hiányzó endpoint, az mvc projektből áthozni apiba 
                return CreatedAtRoute("GetUser", new { controller = "Users", id = createdUser.Id }, createdUser);
            }

            return BadRequest("an error accured while creating a new user");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var signedInUser = await authService.SignInAsync(userLoginDto);

            return Ok(new
            {
                token = tokenHelper.GenerateJWTToken(signedInUser),
                user = signedInUser
            });
        }
    }
}