using Microsoft.EntityFrameworkCore;
using SwapVideos.Data.Models;
using SwapVideos.Data.Repositories.Interfaces;

namespace SwapVideos.Data.Repositories;

public class SwapVideoEntityRepository: BaseRepository<SwapVideoEntity>, ISwapVideoEntityRepository
{
    public SwapVideoEntityRepository(SwapVideosContext context) : base(context)
    {
    }

    public override IQueryable<SwapVideoEntity> GetQueryWithAllIncludes()
    {
        var query = DbSet as IQueryable<SwapVideoEntity>;

        query = query
            .AsNoTracking()
            .AsSplitQuery();

        return query;
    }

    public override SwapVideoEntity CheckSoftDelete(SwapVideoEntity entity)
    {
        if (entity == null)
            return null;

        if (entity.DestroyedAt != null || entity.DestroyedBy != null)
            return null;

        return entity;
    }

    public (List<SwapVideoEntity>? videos, int totalsize) GetAll(int size, int page)
    {
        var query = GetQueryWithAllIncludes();

        query = query.Where(a => a.DestroyedAt == null || a.DestroyedBy == null);

        var totalSize = query.Count();

        query = query
            .Skip(size * page)
            .Take(size)
            .OrderBy(a => a.CreatedAt);

        return (query.ToList(), totalSize);
    }

    public bool ExistsById(Guid id)
    {
        return DbSet.Any(a => a.Id == id
                              && a.DestroyedAt == null
                              && a.DestroyedBy == null);
    }
}