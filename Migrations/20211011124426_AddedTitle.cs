using Microsoft.EntityFrameworkCore.Migrations;

namespace FunctionApp.Migrations
{
    public partial class AddedTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CompanyUpdates",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Title",
                table: "CompanyUpdates");
        }
    }
}
