using AutoMapper;
using BLL.DTO.UserDtos;
using JokrStore.API.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Threading.Tasks;

namespace JokrStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [AllowAnonymous]
    public class AuthController : ControllerBase
    {
        private readonly TokenHelper tokenHelper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;
        private readonly IMapper mapper;

        public AuthController(TokenHelper tokenHelper, IMapper mapper,
            UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.tokenHelper = tokenHelper;
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.mapper = mapper;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            //TODO - kerüljön inkább service-be, db model ne legyen a controllerben
            var userToCreate = mapper.Map<User>(userRegisterDto);
            var result = await userManager.CreateAsync(userToCreate, userRegisterDto.Password);
            var userToReturn = mapper.Map<UserDto>(userToCreate);

            if (result.Succeeded)
            {
                //TODO: egyelőre hiányzó endpoint, az mvc projektből áthozni apiba 
                return CreatedAtRoute("GetUser", new { controller = "Users", id = userToCreate.Id }, userToReturn);
            }

            return BadRequest(result.Errors);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            var user = await userManager.FindByNameAsync(userLoginDto.UserName);
            var result = await signInManager.CheckPasswordSignInAsync(user, userLoginDto.Password, false);

            if (result.Succeeded)
            {
                var appUser = mapper.Map<UserDto>(user);

                return Ok(new
                {
                    token = tokenHelper.GenerateJWTToken(user),
                    user = appUser
                });
            }

            return Unauthorized();
        }
    }
}