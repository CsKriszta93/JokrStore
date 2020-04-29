using BLL.DTO.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace BLL.DTO.AuthDtos
{
    public class LoginResultDto
    {
        public IdentityResult Result { get; set; }
        public UserDto User { get; set; }
    }
}
