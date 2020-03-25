using Microsoft.EntityFrameworkCore.Migrations;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class UpdateInitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "facebook_link", "instagram_link", "twitter_link" },
                values: new object[] { "https://www.facebook.com/MVNToken-101312831304651/", "https://www.instagram.com/mvntoken/", "https://twitter.com/MVNtoken" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "facebook_link", "instagram_link", "twitter_link" },
                values: new object[] { "#", "#", "#" });
        }
    }
}
