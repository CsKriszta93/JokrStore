using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class SysReqMappingProfile : Profile
    {
        public SysReqMappingProfile()
        {
            CreateMap<SysReqDto, SysReq>()
                .ReverseMap();

            CreateMap<CPUDto, CPU>()
                .ReverseMap();

            CreateMap<GPUDto, GPU>()
                .ReverseMap(); 

            CreateMap<OSDto, OS>()
                .ReverseMap();   

            CreateMap<SysReqCPUDto, SysReqCPU>()
                .ReverseMap();

            CreateMap<SysReqGPUDto, SysReqGPU>()
                .ReverseMap(); 

            CreateMap<SysReqOSDto, SysReqOS>()
                .ReverseMap();           
        }
    }
}
