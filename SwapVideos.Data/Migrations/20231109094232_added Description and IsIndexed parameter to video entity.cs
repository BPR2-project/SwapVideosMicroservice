using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SwapVideos.Data.Migrations
{
    public partial class addedDescriptionandIsIndexedparametertovideoentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SwapVideoEntities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsIndexed",
                table: "SwapVideoEntities",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "SwapVideoEntities");

            migrationBuilder.DropColumn(
                name: "IsIndexed",
                table: "SwapVideoEntities");
        }
    }
}
