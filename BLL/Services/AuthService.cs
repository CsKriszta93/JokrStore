using AutoMapper;
using BLL.DTO.UserDtos;
using BLL.ServiceInterfaces;
using Microsoft.AspNetCore.Identity;
using Model;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class AuthService : IAuthService
    {
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;
        private readonly SignInManager<User> signInManager;

        public AuthService(IMapper mapper, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            this.mapper = mapper;
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        public async Task<UserDto> CreateUserAsync(UserRegisterDto userRegisterDto)
        {
            var userToCreate = mapper.Map<User>(userRegisterDto);
            await userManager.CreateAsync(userToCreate, userRegisterDto.Password);

            return mapper.Map<UserDto>(userToCreate);
        }

        public async Task<UserDto> SignInAsync(UserLoginDto userLoginDto)
        {
            var user = await userManager.FindByNameAsync(userLoginDto.UserName);
            await signInManager.CheckPasswordSignInAsync(user, userLoginDto.Password, false);

            return mapper.Map<UserDto>(user);
        }
    }
}
