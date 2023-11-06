using Microsoft.EntityFrameworkCore;
using SwapVideos.Data.Models;

namespace SwapVideos.Data;

public class SwapVideosContext: DbContext
{

    public SwapVideosContext(DbContextOptions options) : base(options)
    {
        Database.Migrate();
    }
    
    public DbSet<SwapVideoEntity> SwapVideoEntities { get; set; }
}