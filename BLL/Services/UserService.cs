using AutoMapper;
using BLL.DTO;
using BLL.DTO.UserDtos;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService : IUserService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public UserService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<UserDto> GetUserByIdAsync(Guid id)
        {
            var user = await dbContext.Users
            .Include(x => x.UserGames).ThenInclude(x => x.Game)
            .Include(x => x.Config).ThenInclude(x => x.CPU)
            .Include(x => x.Config).ThenInclude(x => x.GPU)
            .Include(x => x.Config).ThenInclude(x => x.OS)
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<UserDto>(user);
        }

        public async Task SaveConfigAsync(Guid UserId, ConfigDto ConfigDto)
        {
            Config conf = await dbContext.Configs.FirstOrDefaultAsync(x => x.UserId == UserId);

            if (conf == null)
                await dbContext.Configs.AddAsync(mapper.Map<Config>(ConfigDto));
            else
            {
                conf.CPUId = ConfigDto.CPUId;
                conf.RAM = ConfigDto.RAM;
                conf.GPUId = ConfigDto.GPUId;
                conf.GPUSize = ConfigDto.GPU_size;
                conf.OSId = ConfigDto.OSId;
                conf.Others = ConfigDto.others;
            }
            
            await dbContext.SaveChangesAsync();
        }
    }
}
