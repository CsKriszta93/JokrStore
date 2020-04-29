using BLL.DTO.UserDtos;
using Microsoft.AspNetCore.Identity;

namespace BLL.DTO.AuthDtos
{
    public class SignInResultDto
    {
        public bool Succeeded { get; set; }
        public UserDto User { get; set; }
    }
}
