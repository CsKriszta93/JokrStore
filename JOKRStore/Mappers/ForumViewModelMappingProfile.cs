using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;

namespace BLL.Mappers
{
    public class ForumViewModelMappingProfile : Profile
    {
        public ForumViewModelMappingProfile()
        {
            CreateMap<ForumCategoryViewModel, ForumCategoryDto>()
                .ReverseMap();   

            CreateMap<ForumTopicViewModel, ForumTopicDto>()
                .ReverseMap();      
        }
    }
}