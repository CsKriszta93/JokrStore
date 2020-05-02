using AutoMapper;
using BLL.DTO;
using BLL.Helpers;
using BLL.ServiceInterfaces;
using JOKRStore.DAL;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        public async Task<IEnumerable<PropertyDto>> GetManufactDtosAsync(int type)
        {
            var Manufacts = await dbContext.Properties.Where(x => x.type == type).ToListAsync<Property>();
            return mapper.Map<IEnumerable<PropertyDto>>(Manufacts);
        }

        public IEnumerable<string> GetCPUManufacturersForSelectList()
        {
            return EnumHelper<CPUManufacturer>.GetEnumDisplayNameList<CPUManufacturer>();
        }

        public IEnumerable<string> GetGPUManufacturersForSelectList()
        {
            return EnumHelper<GPUManufacturer>.GetEnumDisplayNameList<GPUManufacturer>();
        }

        public IEnumerable<string> GetOSGroupForSelectList()
        {
            return EnumHelper<OSGroup>.GetEnumDisplayNameList<OSGroup>();
        }
    }
}