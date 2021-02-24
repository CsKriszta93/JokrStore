using BLL.DTO;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IAuthService
    {
        Task<LoginResultDto> GetCreateUserResultAsync(UserRegisterDto userRegisterDto);
        Task<SignInResultDto> GetSignInResultAsync(UserLoginDto userLoginDto);
    }
}
