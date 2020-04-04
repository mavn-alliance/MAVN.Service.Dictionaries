using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class AddMobileDownloadLinksInCommonInformation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "download_android_app_link",
                schema: "dictionaries",
                table: "email_notifications_properties",
                type: "varchar(300)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "download_iso_app_link",
                schema: "dictionaries",
                table: "email_notifications_properties",
                type: "varchar(300)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "support_email_address",
                schema: "dictionaries",
                table: "email_notifications_properties",
                type: "varchar(90)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "download_android_app_link", "download_iso_app_link", "support_email_address" },
                values: new object[] { "https://play.google.com/store/apps/details?id=com.mavntechnologies.communitytoken", "http://itunes.apple.com/app/id1470065092", "tokensupport@mavn.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "download_android_app_link",
                schema: "dictionaries",
                table: "email_notifications_properties");

            migrationBuilder.DropColumn(
                name: "download_iso_app_link",
                schema: "dictionaries",
                table: "email_notifications_properties");

            migrationBuilder.DropColumn(
                name: "support_email_address",
                schema: "dictionaries",
                table: "email_notifications_properties");
        }
    }
}
