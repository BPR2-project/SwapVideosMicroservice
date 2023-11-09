using AutoMapper;
using SwapVideos.API.Swagger.Controllers.Generated;
using SwapVideos.Data.Repositories.Interfaces;
using SwapVideos.Services.Interfaces;

namespace SwapVideos.Services;

public class SwapVideosService: ISwapVideosService
{
    private readonly ISwapVideoEntityRepository _swapVideoEntityRepository;
    private readonly IMapper _mapper;

    public SwapVideosService(ISwapVideoEntityRepository swapVideoEntityRepository, IMapper mapper)
    {
        _swapVideoEntityRepository = swapVideoEntityRepository;
        _mapper = mapper;
    }

    public Video? GetVideo(Guid id)
    {
        if (!_swapVideoEntityRepository.ExistsById(id))
            return null;
        
        var swapVideoEntity = _swapVideoEntityRepository.GetById(id);

        return _mapper.Map<Video>(swapVideoEntity);
    }

    public (List<Video> videos, int totalSize) GetAllVideos(int size, int page)
    {
        var swapVideoEntities = _swapVideoEntityRepository.GetAll(size, page);

        var videos = swapVideoEntities.videos
            .Select(a => _mapper.Map<Video>(a))
            .ToList();
        return (videos, swapVideoEntities.totalsize);
    }

    public Video? TagVideoAsIndexed(Guid id, bool isIndexed)
    {
        if (!_swapVideoEntityRepository.ExistsById(id))
            return null;

        var videoEntity = _swapVideoEntityRepository.GetById(id);

        videoEntity.IsIndexed = isIndexed;
        
        _swapVideoEntityRepository.Update(videoEntity, "system");
        _swapVideoEntityRepository.Save();

        return _mapper.Map<Video>(videoEntity);
    }
}