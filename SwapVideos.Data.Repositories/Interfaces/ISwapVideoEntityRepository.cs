using SwapVideos.Data.Models;

namespace SwapVideos.Data.Repositories.Interfaces;

public interface ISwapVideoEntityRepository: IRepository<SwapVideoEntity>
{
    /// <summary>
    /// Retrieves a paginated list of videos alongside the total size in the db
    /// </summary>
    /// <param name="size">Requested size of the page</param>
    /// <param name="page">PAge number to retrieve</param>
    /// <returns>Returns a paginated list of videos</returns>
    (List<SwapVideoEntity>? videos, int totalsize) GetAll(int size, int page);

    /// <summary>
    /// Checks whether the video exists
    /// </summary>
    /// <param name="id">Id of the video</param>
    /// <returns>Returns a true if the video exists in db</returns>
    bool ExistsById(Guid id);
}