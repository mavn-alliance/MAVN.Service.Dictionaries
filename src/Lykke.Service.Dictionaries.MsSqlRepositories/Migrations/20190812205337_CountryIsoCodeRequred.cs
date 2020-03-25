using Microsoft.EntityFrameworkCore.Migrations;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class CountryIsoCodeRequred : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(3)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(3)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(2)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(2)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(3)");

            migrationBuilder.AlterColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(2)");

            migrationBuilder.AlterColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(3)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(3)");

            migrationBuilder.AlterColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(2)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(2)");
        }
    }
}
