using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;

namespace BLL.ServiceInterfaces
{
    public interface IUserService
    {
        Task<UserDto> GetUserByIdAsync(Guid id);
    }
}