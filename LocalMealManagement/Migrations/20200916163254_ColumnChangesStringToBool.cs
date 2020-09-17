using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalMealManagement.Migrations
{
    public partial class ColumnChangesStringToBool : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "WillYOuRecomand",
                table: "CustomerInfos",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "WillYOuRecomand",
                table: "CustomerInfos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool));
        }
    }
}
