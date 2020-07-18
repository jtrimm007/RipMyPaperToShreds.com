using Microsoft.EntityFrameworkCore.Migrations;

namespace RipMyPaperToShreds.com.Migrations
{
    public partial class AddPaperIdToShreds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaperId",
                table: "Shreds",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaperId",
                table: "Shreds");
        }
    }
}
