using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class UpdateInitialDataPolicyLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "privacy_policy_link", "terms_and_conditions_link" },
                values: new object[] { "https://mvntoken.mavn.com/en/policy", "https://mvntoken.mavn.com/en/terms" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "privacy_policy_link", "terms_and_conditions_link" },
                values: new object[] { "#", "https://customer-website.falcon-staging.open-source.exchange/en/terms" });
        }
    }
}
