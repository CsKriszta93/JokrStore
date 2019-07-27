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
                .FirstOrDefaultAsync(x => x.Id == id);

            return mapper.Map<UserDto>(user);
        }
    }
}