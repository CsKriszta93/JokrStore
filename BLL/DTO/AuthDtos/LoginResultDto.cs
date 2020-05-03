using BLL.DTO;
using Microsoft.AspNetCore.Identity;

namespace BLL.DTO
{
    public class LoginResultDto
    {
        public IdentityResult Result { get; set; }
        public UserDto User { get; set; }
    }
}
