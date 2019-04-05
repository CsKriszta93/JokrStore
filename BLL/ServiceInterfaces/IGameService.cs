using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetGamesAsync();
        Task<GameDto> GetGameByIdAsync(Guid id);
        Task DeleteAsync(Guid id);
        Task<UserDto> GetUserByIdAsync(Guid id);
    }
}
