using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class AerCountryPhoneNumber : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 1,
                column: "country_iso2_code",
                value: "AE");

            migrationBuilder.InsertData(
                schema: "dictionaries",
                table: "country_phone_codes",
                columns: new[] { "id", "code", "country_iso2_code", "country_iso3_code", "country_name", "is_available", "iso_phone_code", "order" },
                values: new object[] { 243, "00971", "AE", "ARE", "United Arab Emirates", true, "+971", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 243);

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 1,
                column: "country_iso2_code",
                value: "AR");
        }
    }
}
