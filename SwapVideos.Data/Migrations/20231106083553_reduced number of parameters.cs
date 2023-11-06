using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwapVideos.Data.Migrations
{
    public partial class reducednumberofparameters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AMSJobName",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "AMSLocatorName",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "AMSOutputAssetName",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "DescriptionFormattedString",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "DescriptionHtmlCode",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "ExternalId",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "InternalName",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsCountingInAsWeeklyWatch",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsInternallyModified",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsLearningMaterial",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsPublished",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsUploadedTowardsAMS",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "OrderInCategory",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "ThumbnailUri",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "TotalClicks",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "VideoLength",
                table: "SwapVideoEntities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AMSJobName",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AMSLocatorName",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AMSOutputAssetName",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionFormattedString",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionHtmlCode",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExternalId",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InternalName",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCountingInAsWeeklyWatch",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsInternallyModified",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsLearningMaterial",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsPublished",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsUploadedTowardsAMS",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OrderInCategory",
                table: "SwapVideoEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThumbnailUri",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalClicks",
                table: "SwapVideoEntities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VideoLength",
                table: "SwapVideoEntities",
                type: "int",
                nullable: true);
        }
    }
}
