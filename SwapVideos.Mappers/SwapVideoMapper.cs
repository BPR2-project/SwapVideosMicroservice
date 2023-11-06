using AutoMapper;
using SwapVideos.API.Swagger.Controllers.Generated;
using SwapVideos.Data.Models;

namespace SwapVideos.Mappers;

public class SwapVideoMapper: Profile
{
    public SwapVideoMapper()
    {
        CreateMap<SwapVideoEntity, Video>()
            .ForMember(a => a.Id, opt => opt.MapFrom(a => a.Id))
            .ForMember(a => a.Name, opt => opt.MapFrom(a => a.Name))
            .ForMember(a => a.VideoLink, opt => opt.MapFrom(a => a.VideoLink));
        
        CreateMap<Video, SwapVideoEntity>()
            .ForMember(a => a.Id, opt => opt.MapFrom(a => a.Id))
            .ForMember(a => a.Name, opt => opt.MapFrom(a => a.Name))
            .ForMember(a => a.VideoLink, opt => opt.MapFrom(a => a.VideoLink));
    }
}