using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class AlignSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "download_app_link", "terms_and_conditions_link" },
                values: new object[] { "https://apadmanabhan1.wixsite.com/eapp", "https://customer-website.falcon-staging.open-source.exchange/en/terms" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "download_app_link", "terms_and_conditions_link" },
                values: new object[] { "#", "#" });
        }
    }
}
