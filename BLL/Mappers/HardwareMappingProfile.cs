using AutoMapper;
using BLL.Helpers;
using Model.Enums;

namespace BLL.Mappers
{
    public class HardwareMappingProfile : Profile
    {
        public HardwareMappingProfile()
        {
            CreateMap<CPUManufacturer, string>()
                .ConvertUsing(src => src.GetDisplayName());
        }
    }
}
