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
        Task DeleteGameAsync(Guid id);
        Task AddGameToUser(Guid UserId, Guid GameId);
    }
}
