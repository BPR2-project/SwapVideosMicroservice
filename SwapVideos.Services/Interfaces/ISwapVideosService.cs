using SwapVideos.API.Swagger.Controllers.Generated;

namespace SwapVideos.Services.Interfaces;

public interface ISwapVideosService
{
    Video? GetVideo(Guid id);
    (List<Video> videos, int totalSize) GetAllVideos(int size, int page);
}