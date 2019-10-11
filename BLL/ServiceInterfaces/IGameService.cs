﻿using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace BLL.ServiceInterfaces
{
    public interface IGameService
    {
        Task<IEnumerable<GameDto>> GetGamesAsync();
        Task<GameDto> GetGameByIdAsync(Guid id);
        Task DeleteGameAsync(Guid id);
        Task DeleteMediaAsync(Guid id);
        Task AddGameToUser(Guid UserId, Guid GameId);
        Task<IEnumerable<GameDto>> GetUserGames(Guid UserId);
        Task<IEnumerable<PropertyDto>> GetPropertyDtosAsync(int type);
        bool IsOwnedGame(Guid UserId, Guid GameId);
        Task AddGameAsync(Guid UserId, GameDto GameDto, IEnumerable<PropertyDto> GenresDto,List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir);
        Task EditGameAsync(Guid UserId, GameDto new_game, IEnumerable<PropertyDto> new_genres, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir);
        Task<bool> GameHasPropery(Guid GameId, Guid PropertyId);
    }
}