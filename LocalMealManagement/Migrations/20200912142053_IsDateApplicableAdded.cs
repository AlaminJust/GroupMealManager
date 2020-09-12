using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalMealManagement.Migrations
{
    public partial class IsDateApplicableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDateApplicable",
                table: "subGroups",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDateApplicable",
                table: "subGroups");
        }
    }
}
