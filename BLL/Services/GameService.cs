﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using Model;
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

        public async Task<IEnumerable<GameDto>> GetGamesAsync()
        {
            var games = await dbContext
                .Games
                .ProjectTo<GameDto>(mapper.ConfigurationProvider)
                .ToListAsync();

            return games;
        }

        public async Task<GameDto> GetGameByIdAsync(Guid id)
        {
            var game = await dbContext.Games
                .Include(x => x.Comments).ThenInclude(x => x.user)
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<GameDto>(game);
        }

        public async Task DeleteAsync(Guid id)
        {
            var gameToDelete = await dbContext.Games
                .SingleOrDefaultAsync(x => x.Id == id);

            dbContext.Games.Remove(mapper.Map<Game>(gameToDelete));
            await dbContext.SaveChangesAsync();
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var user = await dbContext.Users
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<UserDto>(user);
        }
    }
}

