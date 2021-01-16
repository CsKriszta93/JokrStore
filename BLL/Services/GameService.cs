using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;
using BLL.Helpers;

namespace BLL.Services
{
    public class GameService : IGameService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public GameService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<HomeGamesDto> GetHomeGamesAsync()
        {
            return new HomeGamesDto
            {
                NewReleases = await GetGamesByStateAsync(0),
                NewTests = await GetGamesByStateAsync(1)
            };
        }

        public async Task<IEnumerable<GameDtoLite>> GetGamesAsync(GameParams gameFilters)
        {
            var games = await dbContext.Games
                .Skip((gameFilters.CurrentPage -1) * gameFilters.PageSize)
                .Take(gameFilters.PageSize)
                .ProjectTo<GameDtoLite>(mapper.ConfigurationProvider)
                .ToListAsync();

            return games;
        }

        public async Task<int> GetGamesCountAsync()
        {
            return await dbContext.Games.CountAsync();
        }

        public async Task<IEnumerable<GameDtoLite>> GetGamesByStateAsync(int state)
        {
            var games = await dbContext.Games
                .Where(x => x.State == state)
                .OrderBy(x => x.Release)
                .Take(6)
                .ProjectTo<GameDtoLite>(mapper.ConfigurationProvider)
                .ToListAsync();

            return games;
        }

        public async Task<GameDto> GetGameByIdAsync(Guid id)
        {
            var game = await dbContext.Games
                .Include(x => x.Comments).ThenInclude(x => x.User)
                .Include(x => x.Medias)
                .Include(x => x.MinSysReq).ThenInclude(x => x.SysReqCPUs).ThenInclude(x => x.CPU)
                .Include(x => x.MinSysReq).ThenInclude(x => x.SysReqGPUs).ThenInclude(x => x.GPU)
                .Include(x => x.MinSysReq).ThenInclude(x => x.SysReqOSes).ThenInclude(x => x.OS)
                .Include(x => x.RecSysReq).ThenInclude(x => x.SysReqCPUs).ThenInclude(x => x.CPU)
                .Include(x => x.RecSysReq).ThenInclude(x => x.SysReqGPUs).ThenInclude(x => x.GPU)
                .Include(x => x.RecSysReq).ThenInclude(x => x.SysReqOSes).ThenInclude(x => x.OS)
                .Include(x => x.Genres).ThenInclude(x => x.Property)
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<GameDto>(game);
        }

        public async Task DeleteGameAsync(Guid id)
        {
            var gameToDelete = await dbContext.Games
                .SingleOrDefaultAsync(x => x.Id == id);

            dbContext.Games.Remove(mapper.Map<Game>(gameToDelete));
            await dbContext.SaveChangesAsync();
        }

        public async Task DeleteMediaAsync(Guid id)
        {
            var mediaToDelete = await dbContext.Medias
                .SingleOrDefaultAsync(x => x.Id == id);

            dbContext.Medias.Remove(mapper.Map<Media>(mediaToDelete));
            await dbContext.SaveChangesAsync();
        }

        //public async Task AddGameToUser(Guid UserId, Guid GameId)
        //{
        //    dbContext.UserGames.Add(new Model.UserGames(UserId, GameId));
        //    await dbContext.SaveChangesAsync();
        //}

        public async Task<IEnumerable<GameDto>> GetUserGames(Guid UserId)
        {
            var usergames = await dbContext.UserGames.Include(x => x.Game).Where(x => x.UserId == UserId).ToListAsync<UserGames>();
            return  mapper.Map<IEnumerable<GameDto>>(usergames.Select(x => x.Game));
        }

        public async Task<IEnumerable<PropertyDto>> GetPropertyDtosAsync(int type)
        {
            var Properties = await dbContext.Properties.Where(x => x.type == type).ToListAsync<Property>();
            return mapper.Map<IEnumerable<PropertyDto>>(Properties);
        }

        public bool IsOwnedGame(Guid UserId, Guid GameId)
        {
            if (dbContext.UserGames.Where( x => x.UserId == UserId && x.GameId == GameId).Count() == 0)
                return false;
            else
                return true;
        }

        public async Task AddGameAsync(Guid UserId, GameDto GameDto, IEnumerable<PropertyDto> GenresDto, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir)
        {
            var Game = mapper.Map<Game>(GameDto);

            Game.Genres = new List<GameProperty>();
            foreach (var g in GenresDto)
            {
                Game.Genres.Add(new GameProperty
                {
                    Property = await dbContext.Properties.FirstOrDefaultAsync(x => x.Id == g.Id),
                    Game = Game
                });
            }

            Game.Medias = new List<Media>();
            await SaveMediasAsync(Game, Medias, CoverArt, rootdir);
                
            await dbContext.Games.AddAsync(Game);
            await dbContext.SaveChangesAsync();

            GameDto.Id = Game.Id;
        }

        public async Task EditGameAsync(Guid UserId, GameDto new_game, IEnumerable<PropertyDto> new_genres, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir)
        {
            var game = await dbContext.Games
            .Include(x => x.Medias)
            .FirstOrDefaultAsync(x => x.Id == new_game.Id);

            game.GameName = new_game.GameName;
            game.Price = new_game.Price;
            game.Release = new_game.Release;

            var genres_to_delete = await dbContext.GameProperties.Where(x => x.GameId == new_game.Id && x.Property.type == 0).ToListAsync();
            dbContext.GameProperties.RemoveRange(genres_to_delete);

            foreach (var g in new_genres)
            {
                System.Diagnostics.Debug.WriteLine("A genre:" + g.name);
                dbContext.GameProperties.Add(new GameProperty
                    {
                        GameId = game.Id,
                        PropertyId = g.Id
                    }
                );
            }

            await SaveMediasAsync(game, Medias, CoverArt, rootdir);
            
            await dbContext.SaveChangesAsync();
        }

        public async Task<bool> GameHasPropery(Guid GameId, Guid PropertyId)
        {
            return await dbContext.GameProperties.Where(x => x.GameId == GameId && x.PropertyId == PropertyId).CountAsync() > 0;
        }

        public async Task EditGameSysReqAsync(Guid GameId, SysReqDto MinSysReqDto, SysReqDto RecSysReqDto)
        {
            var Game = await dbContext.Games
            .Include(x => x.MinSysReq)
            .FirstOrDefaultAsync(x => x.Id == GameId);

            Game.MinSysReq = mapper.Map<SysReq>(MinSysReqDto);
            Game.RecSysReq = mapper.Map<SysReq>(RecSysReqDto);

            await dbContext.SaveChangesAsync();
        }

        private async Task SaveMediasAsync(Game game, List<IFormFile> Medias, List<IFormFile> CoverArt, string rootdir)
        {
            if (!System.IO.Directory.Exists(rootdir)) 
                    System.IO.Directory.CreateDirectory(rootdir);
            
            foreach (var Media in Medias)
            {
                var media_path = Guid.NewGuid() + ".jpg";
                using (var stream = System.IO.File.Create(rootdir + '/' + media_path))
                {
                    await Media.CopyToAsync(stream);
                    game.Medias.Add(new Media{
                        game = game,
                        type = 0,
                        contain = media_path
                    });
                }
            }

            if (CoverArt.Count() > 0)
            {   
                using (var stream = System.IO.File.Create(rootdir + "/CoverArt.jpg"))
                {
                    await CoverArt.First().CopyToAsync(stream);
                }
            }
        }
    }
}