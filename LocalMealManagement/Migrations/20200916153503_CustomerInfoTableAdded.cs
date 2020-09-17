using Microsoft.EntityFrameworkCore.Migrations;

namespace LocalMealManagement.Migrations
{
    public partial class CustomerInfoTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CustomerInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    StreatAddress1 = table.Column<string>(nullable: true),
                    StreatAddress2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    State = table.Column<string>(nullable: true),
                    Zip = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    HowYouKnowAboutUs = table.Column<string>(nullable: true),
                    FeedBack = table.Column<string>(nullable: true),
                    SuggestionsToImprove = table.Column<string>(nullable: true),
                    WillYOuRecomand = table.Column<string>(nullable: true),
                    ProfilePictureLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerInfos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CustomerInfos");
        }
    }
}
