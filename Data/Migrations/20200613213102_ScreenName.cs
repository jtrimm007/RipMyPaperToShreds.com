using Microsoft.EntityFrameworkCore.Migrations;

namespace RipMyPaperToShreds.com.Data.Migrations
{
    public partial class ScreenName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ScreenName",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ScreenName",
                table: "AspNetUsers");
        }
    }
}
