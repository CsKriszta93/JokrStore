using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Mappers
{
    public class SysReqViewMappingProfile : Profile
    {
        public SysReqViewMappingProfile()
        {
            CreateMap<SysReqViewModel, SysReqDto>()
                .ReverseMap();

            CreateMap<CPUViewModel, CPUDto>()
                .ReverseMap();

            CreateMap<GPUViewModel, GPUDto>()
                .ReverseMap(); 

            CreateMap<OSViewModel, OSDto>()
                .ReverseMap();   

            CreateMap<SysReqCPUViewModel, SysReqCPUDto>()
                .ReverseMap();

            CreateMap<SysReqGPUViewModel, SysReqGPUDto>()
                .ReverseMap(); 

            CreateMap<SysReqOSViewModel, SysReqOSDto>()
                .ReverseMap();           
        }
    }
}
