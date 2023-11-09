using Microsoft.AspNetCore.Mvc;
using SwapVideos.API.Swagger.Controllers.Generated;
using SwapVideos.Extensions;
using SwapVideos.Services.Interfaces;

namespace SwapVideos.API.Controllers;

public class SwapVideoController : VideoControllerBase
{
    private readonly ISwapVideosService _swapVideosService;

    public SwapVideoController(ISwapVideosService swapVideosService)
    {
        _swapVideosService = swapVideosService;
    }

    public override Task<ActionResult<PaginatedVideosResponse>> GetAllVideos(PaginatedVideosRequest paginatedVideosRequest)
    {
        return Task.Run<ActionResult<PaginatedVideosResponse>>(() =>
        {
            var modelState = ModelState.GetAllErrors();
            if (modelState.Any())
                return BadRequest(string.Join("\n", modelState));

            if (paginatedVideosRequest.Size is 0 or null)
                paginatedVideosRequest.Size = 10;
            if (paginatedVideosRequest.Page is null)
                paginatedVideosRequest.Page = 0;

            var allVideos = _swapVideosService.GetAllVideos(paginatedVideosRequest.Size.Value, paginatedVideosRequest.Page.Value);

            if (allVideos.videos.Any() == false)
                return Ok(new PaginatedVideosResponse()
                {
                    Videos = new List<Video>(),
                    CurrentPage = 1,
                    SizeRequested = paginatedVideosRequest.Size,
                    TotalAmount = 0,
                    TotalAmountOfPages = 1
                });
            var response = new PaginatedVideosResponse()
            {
                Videos = allVideos.videos,
                CurrentPage = paginatedVideosRequest.Page,
                SizeRequested = paginatedVideosRequest.Size,
                TotalAmount = allVideos.totalSize,
                TotalAmountOfPages = (int)Math.Ceiling((double)allVideos.totalSize / paginatedVideosRequest.Size.Value)
            };
            return Ok(response);
        });
    }

    public override Task<ActionResult<Video>> GetVideo(Guid videoId)
    {
        return Task.Run<ActionResult<Video>>(() =>
        {
            var swapVideo = _swapVideosService.GetVideo(videoId);

            if (swapVideo == null)
                return NotFound();

            return Ok(swapVideo);
        });
    }

    public override Task<ActionResult<Video>> TagVideoAsIndexed(Guid videoId, bool? isIndexed)
    {
        return Task.Run<ActionResult<Video>>(() =>
        {
            var video = _swapVideosService.TagVideoAsIndexed(videoId, isIndexed ?? false);

            if (video == null)
                return NotFound();

            return Ok(video);
        });
    }
}