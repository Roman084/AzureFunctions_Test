using Microsoft.EntityFrameworkCore.Migrations;

namespace FunctionApp.Migrations
{
    public partial class DeletedCustomerIdAndTitle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Customer_id",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "CompanyUpdates");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Customer_id",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "CompanyUpdates",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
