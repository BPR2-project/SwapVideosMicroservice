namespace SwapVideos.Data.Models;

public class SwapVideoEntity: BaseModel
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool IsIndexed { get; set; }
    public string VideoLink { get; set; }
}