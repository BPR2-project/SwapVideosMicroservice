using SwapVideos.API.Swagger.Controllers.Generated;

namespace SwapVideos.Services.Interfaces;

public interface ISwapVideosService
{
    /// <summary>
    /// Get a video by its id
    /// </summary>
    /// <param name="id">Id of the video</param>
    /// <returns>Returns the video matching the specified id</returns>
    Video? GetVideo(Guid id);
    
    /// <summary>
    /// Gets a paginated list of videos
    /// </summary>
    /// <param name="size">Size of the page</param>
    /// <param name="page">Page number to retrieve</param>
    /// <returns>Returns a list of paginated videos</returns>
    (List<Video> videos, int totalSize) GetAllVideos(int size, int page);

    /// <summary>
    /// Tag a video as indexed or not indexed
    /// </summary>
    /// <param name="videoId">Id of the video to be tagged</param>
    /// <param name="isIndexed">Parameter to determine whether a video is tagged as indexed</param>
    /// <returns>Return the updated video</returns>
    Video? TagVideoAsIndexed(Guid videoId, bool isIndexed);
}