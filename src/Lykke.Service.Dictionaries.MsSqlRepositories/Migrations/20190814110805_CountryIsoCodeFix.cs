using Microsoft.EntityFrameworkCore.Migrations;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class CountryIsoCodeFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CA", "CAN" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "US", "USA" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 17,
                column: "country_iso2_code",
                value: "AX");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AQ", "ATA" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 42,
                column: "country_iso2_code",
                value: "BQ");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CX", "CXR" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 91,
                column: "country_iso2_code",
                value: "FQ");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "RE", "REU" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 187,
                column: "country_iso2_code",
                value: "MF");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 204,
                column: "country_iso2_code",
                value: "GS");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 233,
                column: "name",
                value: "Vietnam");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CA", "CAN" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "US", "USA" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AQ", "ATA" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CX", "CXR" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CC", "CCK" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "CW", "CUW" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AN", "ANT" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "RE", "REU" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "RU", "RUS" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "BL", "BLM" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "MF", "MAF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "UM", "UMI" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 12,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "UM", "UMI" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 17,
                column: "country_iso2_code",
                value: "AL");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 23,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "NF", "NFK" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 42,
                column: "country_iso2_code",
                value: "BE");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 60,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AU", "AUS" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 91,
                column: "country_iso2_code",
                value: "TF");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 179,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "YT", "MYT" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 187,
                column: "country_iso2_code",
                value: "MA");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 204,
                column: "country_iso2_code",
                value: "SG");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "countries_of_residence",
                keyColumn: "id",
                keyValue: 233,
                column: "name",
                value: "Viet Nam");

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "UM", "UMI" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "UM", "UMI" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 22,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "NF", "NFK" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 58,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AU", "AUS" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 59,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "AU", "AUS" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 66,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "BQ", "BES" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 157,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "BQ", "BES" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 182,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "YT", "MYT" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 184,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "KZ", "KAZ" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 186,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "GP", "GLP" });

            migrationBuilder.UpdateData(
                schema: "dictionaries",
                table: "country_phone_codes",
                keyColumn: "id",
                keyValue: 190,
                columns: new[] { "country_iso2_code", "country_iso3_code" },
                values: new object[] { "GP", "GLP" });
        }
    }
}
