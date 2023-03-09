using AutoMapper;
using IdeaSystem.Entities;
using IdeaSystem.Models;

namespace IdeaSystem.Function
{

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Topic, TopicModel>().ForMember(
                des => des.ideaList, // Property của DTO
                act => act.MapFrom(src => src.ideaList));


            CreateMap<Idea, IdeaDetailModel>()
               .ForMember(des => des.commentList,
                                act => act.MapFrom(src => src.commentList))
               .ForMember(des => des.reactList,
                                act => act.MapFrom(src => src.reactList))
               .ForMember(des => des.viewList,
                                act => act.MapFrom(src => src.viewList));

            CreateMap<View, ViewModel>();
            CreateMap<React, ReactModel>();
            CreateMap<Comment, CommentModel>();
        }
    }
}
