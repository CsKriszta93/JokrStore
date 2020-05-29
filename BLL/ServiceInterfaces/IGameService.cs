using BLL.DTO;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDtoLite>> GetGamesAsync();
        Task<IEnumerable<GameDtoLite>> GetGamesByStateAsync(int state);
        Task<GameDto> GetGameByIdAsync(Guid id);
        Task DeleteGameAsync(Guid id);
        Task DeleteMediaAsync(Guid id);
        //Task AddGameToUser(Guid UserId, Guid GameId);
        Task<IEnumerable<GameDto>> GetUserGames(Guid UserId);
        Task<IEnumerable<PropertyDto>> GetPropertyDtosAsync(int type);
        bool IsOwnedGame(Guid UserId, Guid GameId);
        Task AddGameAsync(Guid UserId, GameDto GameDto, IEnumerable<PropertyDto> GenresDto, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir);
        Task EditGameAsync(Guid UserId, GameDto new_game, IEnumerable<PropertyDto> new_genres, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir);
        Task EditGameSysReqAsync(Guid GameId, SysReqDto MinSysReqDto, SysReqDto RecSysReqDto);
        Task<bool> GameHasPropery(Guid GameId, Guid PropertyId);
    }
}