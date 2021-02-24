using BLL.DTO;
using Model.Enums;
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
        //Task<IEnumerable<PropertyDto>> GetManufactDtosAsync(int type);

        IEnumerable<string> GetCPUManufacturersForSelectList();
        IEnumerable<string> GetGPUManufacturersForSelectList();
        IEnumerable<string> GetOSGroupForSelectList();
    }
}