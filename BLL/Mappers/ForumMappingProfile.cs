using AutoMapper;
using BLL.DTO;
using Model;

namespace BLL.Mappers
{
    public class ForumMappingProfile : Profile
    {
        public ForumMappingProfile()
        {
            CreateMap<ForumCategoryDto, ForumCategory>()
                .ReverseMap();   

            CreateMap<ForumTopicDto, ForumTopic>()
                .ReverseMap();      
        }
    }
}