using BLL.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BLL.ServiceInterfaces
{
    public interface IHardwareService
    {
        Task<IEnumerable<CPUDto>> GetCPUsAsync();
        Task<IEnumerable<GPUDto>> GetGPUsAsync();
        Task<IEnumerable<OSDto>> GetOSesAsync();

    }
}