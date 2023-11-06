using SwapVideos.Data.Models;

namespace SwapVideos.Data.Repositories.Interfaces;

public interface ISwapVideoEntityRepository: IRepository<SwapVideoEntity>
{
    (List<SwapVideoEntity>? videos, int totalsize) GetAll(int size, int page);
}