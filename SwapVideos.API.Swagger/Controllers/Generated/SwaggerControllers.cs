//----------------------
// <auto-generated>
//     Generated using the NSwag toolchain v13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0)) (http://NSwag.org)
// </auto-generated>
//----------------------

#pragma warning disable 108 // Disable "CS0108 '{derivedDto}.ToJson()' hides inherited member '{dtoBase}.ToJson()'. Use the new keyword if hiding was intended."
#pragma warning disable 114 // Disable "CS0114 '{derivedDto}.RaisePropertyChanged(String)' hides inherited member 'dtoBase.RaisePropertyChanged(String)'. To make the current member override that implementation, add the override keyword. Otherwise add the new keyword."
#pragma warning disable 472 // Disable "CS0472 The result of the expression is always 'false' since a value of type 'Int32' is never equal to 'null' of type 'Int32?'
#pragma warning disable 612 // Disable "CS0612 '...' is obsolete"
#pragma warning disable 1573 // Disable "CS1573 Parameter '...' has no matching param tag in the XML comment for ...
#pragma warning disable 1591 // Disable "CS1591 Missing XML comment for publicly visible type or member ..."
#pragma warning disable 8073 // Disable "CS8073 The result of the expression is always 'false' since a value of type 'T' is never equal to 'null' of type 'T?'"
#pragma warning disable 3016 // Disable "CS3016 Arrays as attribute arguments is not CLS-compliant"
#pragma warning disable 8603 // Disable "CS8603 Possible null reference return"
#pragma warning disable 8604 // Disable "CS8604 Possible null reference argument for parameter"

namespace SwapVideos.API.Swagger.Controllers.Generated
{
    using System = global::System;

    [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]

    public abstract class VideoControllerBase : Microsoft.AspNetCore.Mvc.Controller
    {
        /// <summary>
        /// Get all videos paginated
        /// </summary>
        /// <remarks>
        /// Get all video paginated
        /// </remarks>
        /// <param name="paginatedVideosRequest">Contains pagination details</param>
        /// <returns>Returns all videos paginated</returns>
        [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("videos")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<PaginatedVideosResponse>> GetAllVideos([Microsoft.AspNetCore.Mvc.FromBody] [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] PaginatedVideosRequest paginatedVideosRequest);

        /// <summary>
        /// Get a video by its id
        /// </summary>
        /// <remarks>
        /// Get a video by its id
        /// </remarks>
        /// <param name="videoId">Video Id to get the video entity for</param>
        /// <returns>Video found</returns>
        [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("video/videoId/{videoId}")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Video>> GetVideo([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid videoId);

        /// <summary>
        /// Tag a video as indexed or not
        /// </summary>
        /// <remarks>
        /// Tag a video as indexed or not
        /// </remarks>
        /// <param name="videoId">Video id</param>
        /// <param name="isIndexed">Bool to state whether the video is indexed or not</param>
        /// <returns>Operation succeded</returns>
        [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("video/videoId/{videoId}")]
        public abstract System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Video>> TagVideoAsIndexed([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Guid videoId, [Microsoft.AspNetCore.Mvc.FromQuery] bool? isIndexed);

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Video
    {
        /// <summary>
        /// Id of the video
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Guid? Id { get; set; }

        /// <summary>
        /// Video name/title
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// Video description
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Description", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// Link to the video's blob storage
        /// </summary>
        [Newtonsoft.Json.JsonProperty("VideoLink", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VideoLink { get; set; }

        /// <summary>
        /// Modifier to show whether the video is indexed or not
        /// </summary>
        [Newtonsoft.Json.JsonProperty("IsIndexed", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsIndexed { get; set; }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static Video FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<Video>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PaginatedVideosRequest
    {
        /// <summary>
        /// Size of the page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Size", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// Page number
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Page", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Page { get; set; }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static PaginatedVideosRequest FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaginatedVideosRequest>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }

    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.20.0.0 (NJsonSchema v10.9.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class PaginatedVideosResponse
    {
        /// <summary>
        /// List of videos
        /// </summary>
        [Newtonsoft.Json.JsonProperty("Videos", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<Video> Videos { get; set; }

        /// <summary>
        /// Size of the page that was requested
        /// </summary>
        [Newtonsoft.Json.JsonProperty("SizeRequested", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? SizeRequested { get; set; }

        /// <summary>
        /// Total number of videos retrieved
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TotalAmount", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalAmount { get; set; }

        /// <summary>
        /// Current page
        /// </summary>
        [Newtonsoft.Json.JsonProperty("CurrentPage", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// Total number of pages based on the specified size
        /// </summary>
        [Newtonsoft.Json.JsonProperty("TotalAmountOfPages", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? TotalAmountOfPages { get; set; }

        public string ToJson()
        {

            return Newtonsoft.Json.JsonConvert.SerializeObject(this, new Newtonsoft.Json.JsonSerializerSettings());

        }
        public static PaginatedVideosResponse FromJson(string data)
        {

            return Newtonsoft.Json.JsonConvert.DeserializeObject<PaginatedVideosResponse>(data, new Newtonsoft.Json.JsonSerializerSettings());

        }

    }


}

#pragma warning restore  108
#pragma warning restore  114
#pragma warning restore  472
#pragma warning restore  612
#pragma warning restore 1573
#pragma warning restore 1591
#pragma warning restore 8073
#pragma warning restore 3016
#pragma warning restore 8603
#pragma warning restore 8604