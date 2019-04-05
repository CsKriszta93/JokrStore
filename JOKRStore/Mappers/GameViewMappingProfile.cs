﻿using AutoMapper;
using BLL.DTO;
using JOKRStore.Web.ViewModels;

namespace JOKRStore.Web.Mappers
{
    public class GameViewMappingProfile : Profile
    {
        public GameViewMappingProfile() 
        {
            CreateMap<GameViewModel, GameDto>().ReverseMap();

            CreateMap<CommentViewModel, CommentDto>()
                .ForMember(e => e.Commenter, opt => opt.MapFrom(e => e.Commenter))
                .ForMember(e => e.CommentDate, opt => opt.MapFrom(e => e.CommentDate))
                .ForMember(e => e.Contain, opt => opt.MapFrom(e => e.Contain));
        }
    }
}
