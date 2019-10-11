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

            CreateMap<PropertyViewModel, PropertyDto>()
                .ForMember(s => s.Id, opt => opt.MapFrom(d => d.Id))
                .ForMember(s => s.name, opt => opt.MapFrom(d => d.name))
                .ForMember(s => s.type, opt => opt.MapFrom(d => d.type))
                .ReverseMap();      
        }
    }
}
