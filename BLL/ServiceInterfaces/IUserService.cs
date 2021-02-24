using BLL.DTO;
using System;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserDto> GetUserByIdAsync(Guid id);
        Task SaveConfigAsync(Guid UserId, ConfigDto ConfigDto);
    }
}
