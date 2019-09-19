using AutoMapper;
using AutoMapper.QueryableExtensions;
using BLL.DTO;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Model;

namespace BLL.Services
{
    public class HardwareService : IHardwareService
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IMapper mapper;

        public HardwareService(ApplicationDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<CPUDto>> GetCPUsAsync()
        {
            var CPUs = await dbContext.CPUs.ToListAsync<CPU>();
            return  mapper.Map<IEnumerable<CPUDto>>(CPUs);
        }

        public async Task<IEnumerable<GPUDto>> GetGPUsAsync()
        {
            var GPUs = await dbContext.GPUs.ToListAsync<GPU>();
            return  mapper.Map<IEnumerable<GPUDto>>(GPUs);
        }

        public async Task<IEnumerable<OSDto>> GetOSesAsync()
        {
            var OSes = await dbContext.OSes.ToListAsync<OS>();
            return  mapper.Map<IEnumerable<OSDto>>(OSes);
        }
    }
}