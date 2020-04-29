using BLL.DTO.AuthDtos;
using BLL.DTO.UserDtos;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<LoginResultDto> GetCreateUserResultAsync(UserRegisterDto userRegisterDto);
        Task<SignInResultDto> GetSignInResultAsync(UserLoginDto userLoginDto);
    }
}
