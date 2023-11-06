using AutoMapper;
using SwapVideos.API.Swagger.Controllers.Generated;
using SwapVideos.Data.Repositories.Interfaces;
using SwapVideos.Services.Interfaces;

namespace SwapVideos.Services;

public class SwapVideosService: ISwapVideosService
{
    private ISwapVideoEntityRepository _swapVideoEntityRepository;
    private IMapper _mapper;

    public SwapVideosService(ISwapVideoEntityRepository swapVideoEntityRepository, IMapper mapper)
    {
        _swapVideoEntityRepository = swapVideoEntityRepository;
        _mapper = mapper;
    }

    public Video? GetVideo(Guid id)
    {
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
}