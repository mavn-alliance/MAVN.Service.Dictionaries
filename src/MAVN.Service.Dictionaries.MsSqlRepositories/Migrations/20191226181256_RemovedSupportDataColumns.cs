using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class RemovedSupportDataColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "support_email_address",
                schema: "dictionaries",
                table: "email_notifications_properties");

            migrationBuilder.DropColumn(
                name: "support_phone_number",
                schema: "dictionaries",
                table: "email_notifications_properties");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "support_email_address",
                schema: "dictionaries",
                table: "email_notifications_properties",
                type: "varchar(90)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "support_phone_number",
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
                columns: new[] { "support_email_address", "support_phone_number" },
                values: new object[] { "tokensupport@mavn.com", "+97144238830" });
        }
    }
}
