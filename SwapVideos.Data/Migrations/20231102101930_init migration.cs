using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwapVideos.Data.Migrations
{
    public partial class initmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SwapVideoEntities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ExternalId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InternalName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbnailUri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionFormattedString = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionHtmlCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VideoLength = table.Column<int>(type: "int", nullable: false),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsInternallyModified = table.Column<bool>(type: "bit", nullable: false),
                    OrderInCategory = table.Column<int>(type: "int", nullable: false),
                    IsCountingInAsWeeklyWatch = table.Column<bool>(type: "bit", nullable: false),
                    IsLearningMaterial = table.Column<bool>(type: "bit", nullable: false),
                    IsUploadedTowardsAMS = table.Column<bool>(type: "bit", nullable: false),
                    AMSLocatorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AMSJobName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AMSOutputAssetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalClicks = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DestroyedAt = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DestroyedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SwapVideoEntities", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SwapVideoEntities");
        }
    }
}
