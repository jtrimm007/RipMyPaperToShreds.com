using Microsoft.EntityFrameworkCore.Migrations;

namespace RipMyPaperToShreds.com.Migrations
{
    public partial class AddingContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Context",
                table: "Shreds",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Context",
                table: "Shreds");
        }
    }
}
