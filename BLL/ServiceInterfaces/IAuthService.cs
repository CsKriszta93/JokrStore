using BLL.DTO.UserDtos;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<UserDto> CreateUserAsync(UserRegisterDto userRegisterDto);
        Task<UserDto> SignInAsync(UserLoginDto userLoginDto);
    }
}
