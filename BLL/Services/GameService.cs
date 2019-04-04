using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<IEnumerable<GameDto>> GetGames()
        {
            var games = await dbContext
                .Games
                .ProjectTo<GameDto>(mapper.ConfigurationProvider)
                .ToListAsync();

            return games;
        }

        public async Task<GameDto> GetGame(Guid id)
        {
            var game = await dbContext.Games
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<GameDto>(game);

            //var game = await mapper.Map<Task<GameDto>>(dbContext.Games.FirstOrDefaultAsync(x => x.Id == id));
            //game.Comments = await dbContext.Comments.Where(x => x.GameId == game.Id).ToListAsync();
            //return game;
        }
    }
}

