using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class CountryIsoCode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "country_phone_codes",
                type: "char(3)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(2)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "countries_of_residence",
                type: "char(3)",
                nullable: true);

            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IN', country_iso3_code = 'IND' WHERE id = 1");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SA', country_iso3_code = 'SAU' WHERE id = 2");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PK', country_iso3_code = 'PAK' WHERE id = 3");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'JO', country_iso3_code = 'JOR' WHERE id = 4");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GB', country_iso3_code = 'GBR' WHERE id = 5");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'EG', country_iso3_code = 'EGY' WHERE id = 6");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SY', country_iso3_code = 'SYR' WHERE id = 7");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UM', country_iso3_code = 'UMI' WHERE id = 8");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LB', country_iso3_code = 'LBN' WHERE id = 9");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SD', country_iso3_code = 'SDN' WHERE id = 10");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UM', country_iso3_code = 'UMI' WHERE id = 11");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KW', country_iso3_code = 'KWT' WHERE id = 12");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IR', country_iso3_code = 'IRN' WHERE id = 13");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IQ', country_iso3_code = 'IRQ' WHERE id = 14");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AF', country_iso3_code = 'AFG' WHERE id = 15");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AL', country_iso3_code = 'ALB' WHERE id = 16");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DZ', country_iso3_code = 'DZA' WHERE id = 17");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AS', country_iso3_code = 'ASM' WHERE id = 18");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AD', country_iso3_code = 'AND' WHERE id = 19");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AO', country_iso3_code = 'AGO' WHERE id = 20");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AI', country_iso3_code = 'AIA' WHERE id = 21");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NF', country_iso3_code = 'NFK' WHERE id = 22");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AG', country_iso3_code = 'ATG' WHERE id = 23");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AR', country_iso3_code = 'ARG' WHERE id = 24");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AM', country_iso3_code = 'ARM' WHERE id = 25");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AW', country_iso3_code = 'ABW' WHERE id = 26");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AU', country_iso3_code = 'AUS' WHERE id = 27");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AT', country_iso3_code = 'AUT' WHERE id = 28");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AZ', country_iso3_code = 'AZE' WHERE id = 29");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BS', country_iso3_code = 'BHS' WHERE id = 30");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BH', country_iso3_code = 'BHR' WHERE id = 31");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BD', country_iso3_code = 'BGD' WHERE id = 32");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BB', country_iso3_code = 'BRB' WHERE id = 33");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BY', country_iso3_code = 'BLR' WHERE id = 34");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BE', country_iso3_code = 'BEL' WHERE id = 35");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BZ', country_iso3_code = 'BLZ' WHERE id = 36");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BJ', country_iso3_code = 'BEN' WHERE id = 37");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BM', country_iso3_code = 'BMU' WHERE id = 38");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BT', country_iso3_code = 'BTN' WHERE id = 39");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BO', country_iso3_code = 'BOL' WHERE id = 40");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BA', country_iso3_code = 'BIH' WHERE id = 41");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BW', country_iso3_code = 'BWA' WHERE id = 42");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BR', country_iso3_code = 'BRA' WHERE id = 43");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IO', country_iso3_code = 'IOT' WHERE id = 44");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VG', country_iso3_code = 'VGB' WHERE id = 45");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BN', country_iso3_code = 'BRN' WHERE id = 46");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BG', country_iso3_code = 'BGR' WHERE id = 47");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BF', country_iso3_code = 'BFA' WHERE id = 48");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BI', country_iso3_code = 'BDI' WHERE id = 49");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KH', country_iso3_code = 'KHM' WHERE id = 50");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CM', country_iso3_code = 'CMR' WHERE id = 51");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CV', country_iso3_code = 'CPV' WHERE id = 52");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KY', country_iso3_code = 'CYM' WHERE id = 53");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CF', country_iso3_code = 'CAF' WHERE id = 54");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TD', country_iso3_code = 'TCD' WHERE id = 55");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CL', country_iso3_code = 'CHL' WHERE id = 56");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CN', country_iso3_code = 'CHN' WHERE id = 57");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AU', country_iso3_code = 'AUS' WHERE id = 58");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'AU', country_iso3_code = 'AUS' WHERE id = 59");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CO', country_iso3_code = 'COL' WHERE id = 60");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KM', country_iso3_code = 'COM' WHERE id = 61");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CK', country_iso3_code = 'COK' WHERE id = 62");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CR', country_iso3_code = 'CRI' WHERE id = 63");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'HR', country_iso3_code = 'HRV' WHERE id = 64");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CU', country_iso3_code = 'CUB' WHERE id = 65");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BQ', country_iso3_code = 'BES' WHERE id = 66");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CY', country_iso3_code = 'CYP' WHERE id = 67");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CZ', country_iso3_code = 'CZE' WHERE id = 68");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CD', country_iso3_code = 'COD' WHERE id = 69");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DK', country_iso3_code = 'DNK' WHERE id = 70");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DJ', country_iso3_code = 'DJI' WHERE id = 71");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DM', country_iso3_code = 'DMA' WHERE id = 72");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DO', country_iso3_code = 'DOM' WHERE id = 73");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DO', country_iso3_code = 'DOM' WHERE id = 74");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DO', country_iso3_code = 'DOM' WHERE id = 75");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TL', country_iso3_code = 'TLS' WHERE id = 76");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'EC', country_iso3_code = 'ECU' WHERE id = 77");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SV', country_iso3_code = 'SLV' WHERE id = 78");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GQ', country_iso3_code = 'GNQ' WHERE id = 79");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ER', country_iso3_code = 'ERI' WHERE id = 80");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'EE', country_iso3_code = 'EST' WHERE id = 81");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ET', country_iso3_code = 'ETH' WHERE id = 82");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FK', country_iso3_code = 'FLK' WHERE id = 83");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FO', country_iso3_code = 'FRO' WHERE id = 84");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FJ', country_iso3_code = 'FJI' WHERE id = 85");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FI', country_iso3_code = 'FIN' WHERE id = 86");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FR', country_iso3_code = 'FRA' WHERE id = 87");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PF', country_iso3_code = 'PYF' WHERE id = 88");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GA', country_iso3_code = 'GAB' WHERE id = 89");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GM', country_iso3_code = 'GMB' WHERE id = 90");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GE', country_iso3_code = 'GEO' WHERE id = 91");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'DE', country_iso3_code = 'DEU' WHERE id = 92");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GH', country_iso3_code = 'GHA' WHERE id = 93");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GI', country_iso3_code = 'GIB' WHERE id = 94");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GR', country_iso3_code = 'GRC' WHERE id = 95");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GL', country_iso3_code = 'GRL' WHERE id = 96");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GD', country_iso3_code = 'GRD' WHERE id = 97");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GU', country_iso3_code = 'GUM' WHERE id = 98");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GT', country_iso3_code = 'GTM' WHERE id = 99");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GG', country_iso3_code = 'GGY' WHERE id = 100");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GN', country_iso3_code = 'GIN' WHERE id = 101");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GW', country_iso3_code = 'GNB' WHERE id = 102");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GY', country_iso3_code = 'GUY' WHERE id = 103");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'HT', country_iso3_code = 'HTI' WHERE id = 104");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'HN', country_iso3_code = 'HND' WHERE id = 105");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'HK', country_iso3_code = 'HKG' WHERE id = 106");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'HU', country_iso3_code = 'HUN' WHERE id = 107");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IS', country_iso3_code = 'ISL' WHERE id = 108");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ID', country_iso3_code = 'IDN' WHERE id = 109");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IE', country_iso3_code = 'IRL' WHERE id = 110");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IM', country_iso3_code = 'IMN' WHERE id = 111");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IL', country_iso3_code = 'ISR' WHERE id = 112");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'IT', country_iso3_code = 'ITA' WHERE id = 113");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CI', country_iso3_code = 'CIV' WHERE id = 114");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'JM', country_iso3_code = 'JAM' WHERE id = 115");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'JP', country_iso3_code = 'JPN' WHERE id = 116");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'JE', country_iso3_code = 'JEY' WHERE id = 117");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KZ', country_iso3_code = 'KAZ' WHERE id = 118");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KE', country_iso3_code = 'KEN' WHERE id = 119");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KI', country_iso3_code = 'KIR' WHERE id = 120");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'XK', country_iso3_code = 'XKX' WHERE id = 121");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KG', country_iso3_code = 'KGZ' WHERE id = 122");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LA', country_iso3_code = 'LAO' WHERE id = 123");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LV', country_iso3_code = 'LVA' WHERE id = 124");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LS', country_iso3_code = 'LSO' WHERE id = 125");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LR', country_iso3_code = 'LBR' WHERE id = 126");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LY', country_iso3_code = 'LBY' WHERE id = 127");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LI', country_iso3_code = 'LIE' WHERE id = 128");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LT', country_iso3_code = 'LTU' WHERE id = 129");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LU', country_iso3_code = 'LUX' WHERE id = 130");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MO', country_iso3_code = 'MAC' WHERE id = 131");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MK', country_iso3_code = 'MKD' WHERE id = 132");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MG', country_iso3_code = 'MDG' WHERE id = 133");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MW', country_iso3_code = 'MWI' WHERE id = 134");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MY', country_iso3_code = 'MYS' WHERE id = 135");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MV', country_iso3_code = 'MDV' WHERE id = 136");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ML', country_iso3_code = 'MLI' WHERE id = 137");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MT', country_iso3_code = 'MLT' WHERE id = 138");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MH', country_iso3_code = 'MHL' WHERE id = 139");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MR', country_iso3_code = 'MRT' WHERE id = 140");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MU', country_iso3_code = 'MUS' WHERE id = 141");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'YT', country_iso3_code = 'MYT' WHERE id = 142");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MX', country_iso3_code = 'MEX' WHERE id = 143");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'FM', country_iso3_code = 'FSM' WHERE id = 144");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MD', country_iso3_code = 'MDA' WHERE id = 145");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MC', country_iso3_code = 'MCO' WHERE id = 146");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MN', country_iso3_code = 'MNG' WHERE id = 147");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ME', country_iso3_code = 'MNE' WHERE id = 148");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MS', country_iso3_code = 'MSR' WHERE id = 149");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MA', country_iso3_code = 'MAR' WHERE id = 150");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MZ', country_iso3_code = 'MOZ' WHERE id = 151");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MM', country_iso3_code = 'MMR' WHERE id = 152");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NA', country_iso3_code = 'NAM' WHERE id = 153");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NR', country_iso3_code = 'NRU' WHERE id = 154");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NP', country_iso3_code = 'NPL' WHERE id = 155");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NL', country_iso3_code = 'NLD' WHERE id = 156");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'BQ', country_iso3_code = 'BES' WHERE id = 157");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NC', country_iso3_code = 'NCL' WHERE id = 158");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NZ', country_iso3_code = 'NZL' WHERE id = 159");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NI', country_iso3_code = 'NIC' WHERE id = 160");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NE', country_iso3_code = 'NER' WHERE id = 161");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NG', country_iso3_code = 'NGA' WHERE id = 162");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NU', country_iso3_code = 'NIU' WHERE id = 163");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MP', country_iso3_code = 'MNP' WHERE id = 164");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KP', country_iso3_code = 'PRK' WHERE id = 165");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NO', country_iso3_code = 'NOR' WHERE id = 166");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'OM', country_iso3_code = 'OMN' WHERE id = 167");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PW', country_iso3_code = 'PLW' WHERE id = 168");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PS', country_iso3_code = 'PSE' WHERE id = 169");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PA', country_iso3_code = 'PAN' WHERE id = 170");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PG', country_iso3_code = 'PNG' WHERE id = 171");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PY', country_iso3_code = 'PRY' WHERE id = 172");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PE', country_iso3_code = 'PER' WHERE id = 173");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PH', country_iso3_code = 'PHL' WHERE id = 174");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NZ', country_iso3_code = 'NZL' WHERE id = 175");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PL', country_iso3_code = 'POL' WHERE id = 176");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PT', country_iso3_code = 'PRT' WHERE id = 177");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PR', country_iso3_code = 'PRI' WHERE id = 178");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PR', country_iso3_code = 'PRI' WHERE id = 179");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'QA', country_iso3_code = 'QAT' WHERE id = 180");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CG', country_iso3_code = 'COG' WHERE id = 181");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'YT', country_iso3_code = 'MYT' WHERE id = 182");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'RO', country_iso3_code = 'ROU' WHERE id = 183");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KZ', country_iso3_code = 'KAZ' WHERE id = 184");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'RW', country_iso3_code = 'RWA' WHERE id = 185");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GP', country_iso3_code = 'GLP' WHERE id = 186");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SH', country_iso3_code = 'SHN' WHERE id = 187");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KN', country_iso3_code = 'KNA' WHERE id = 188");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LC', country_iso3_code = 'LCA' WHERE id = 189");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'GP', country_iso3_code = 'GLP' WHERE id = 190");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'PM', country_iso3_code = 'SPM' WHERE id = 191");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VC', country_iso3_code = 'VCT' WHERE id = 192");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'WS', country_iso3_code = 'WSM' WHERE id = 193");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SM', country_iso3_code = 'SMR' WHERE id = 194");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ST', country_iso3_code = 'STP' WHERE id = 195");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SN', country_iso3_code = 'SEN' WHERE id = 196");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'RS', country_iso3_code = 'SRB' WHERE id = 197");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SC', country_iso3_code = 'SYC' WHERE id = 198");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SL', country_iso3_code = 'SLE' WHERE id = 199");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SG', country_iso3_code = 'SGP' WHERE id = 200");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SX', country_iso3_code = 'SXM' WHERE id = 201");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SK', country_iso3_code = 'SVK' WHERE id = 202");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SI', country_iso3_code = 'SVN' WHERE id = 203");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SB', country_iso3_code = 'SLB' WHERE id = 204");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SO', country_iso3_code = 'SOM' WHERE id = 205");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ZA', country_iso3_code = 'ZAF' WHERE id = 206");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'KR', country_iso3_code = 'KOR' WHERE id = 207");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SS', country_iso3_code = 'SSD' WHERE id = 208");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ES', country_iso3_code = 'ESP' WHERE id = 209");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'LK', country_iso3_code = 'LKA' WHERE id = 210");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SR', country_iso3_code = 'SUR' WHERE id = 211");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'NO', country_iso3_code = 'NOR' WHERE id = 212");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SZ', country_iso3_code = 'SWZ' WHERE id = 213");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'SE', country_iso3_code = 'SWE' WHERE id = 214");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'CH', country_iso3_code = 'CHE' WHERE id = 215");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TW', country_iso3_code = 'TWN' WHERE id = 216");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TJ', country_iso3_code = 'TJK' WHERE id = 217");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TZ', country_iso3_code = 'TZA' WHERE id = 218");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TH', country_iso3_code = 'THA' WHERE id = 219");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TG', country_iso3_code = 'TGO' WHERE id = 220");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TK', country_iso3_code = 'TKL' WHERE id = 221");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TO', country_iso3_code = 'TON' WHERE id = 222");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TT', country_iso3_code = 'TTO' WHERE id = 223");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TN', country_iso3_code = 'TUN' WHERE id = 224");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TR', country_iso3_code = 'TUR' WHERE id = 225");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TM', country_iso3_code = 'TKM' WHERE id = 226");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TC', country_iso3_code = 'TCA' WHERE id = 227");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'TV', country_iso3_code = 'TUV' WHERE id = 228");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VI', country_iso3_code = 'VIR' WHERE id = 229");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UG', country_iso3_code = 'UGA' WHERE id = 230");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UA', country_iso3_code = 'UKR' WHERE id = 231");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UY', country_iso3_code = 'URY' WHERE id = 232");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'UZ', country_iso3_code = 'UZB' WHERE id = 233");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VU', country_iso3_code = 'VUT' WHERE id = 234");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VA', country_iso3_code = 'VAT' WHERE id = 235");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VE', country_iso3_code = 'VEN' WHERE id = 236");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'VN', country_iso3_code = 'VNM' WHERE id = 237");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'WF', country_iso3_code = 'WLF' WHERE id = 238");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'MA', country_iso3_code = 'MAR' WHERE id = 239");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'YE', country_iso3_code = 'YEM' WHERE id = 240");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ZM', country_iso3_code = 'ZMB' WHERE id = 241");
            migrationBuilder.Sql(
                "UPDATE dictionaries.country_phone_codes SET country_iso2_code = 'ZW', country_iso3_code = 'ZWE' WHERE id = 242");

            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AR', country_iso3_code = 'ARE' WHERE id = 1");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IN', country_iso3_code = 'IND' WHERE id = 2");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SA', country_iso3_code = 'SAU' WHERE id = 3");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PK', country_iso3_code = 'PAK' WHERE id = 4");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'JO', country_iso3_code = 'JOR' WHERE id = 5");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GB', country_iso3_code = 'GBR' WHERE id = 6");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'EG', country_iso3_code = 'EGY' WHERE id = 7");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SY', country_iso3_code = 'SYR' WHERE id = 8");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UM', country_iso3_code = 'UMI' WHERE id = 9");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LB', country_iso3_code = 'LBN' WHERE id = 10");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SD', country_iso3_code = 'SDN' WHERE id = 11");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UM', country_iso3_code = 'UMI' WHERE id = 12");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KW', country_iso3_code = 'KWT' WHERE id = 13");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IR', country_iso3_code = 'IRN' WHERE id = 14");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IQ', country_iso3_code = 'IRQ' WHERE id = 15");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AF', country_iso3_code = 'AFG' WHERE id = 16");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AL', country_iso3_code = 'ALA' WHERE id = 17");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AL', country_iso3_code = 'ALB' WHERE id = 18");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DZ', country_iso3_code = 'DZA' WHERE id = 19");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AD', country_iso3_code = 'AND' WHERE id = 20");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AO', country_iso3_code = 'AGO' WHERE id = 21");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AI', country_iso3_code = 'AIA' WHERE id = 22");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NF', country_iso3_code = 'NFK' WHERE id = 23");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AG', country_iso3_code = 'ATG' WHERE id = 24");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AR', country_iso3_code = 'ARG' WHERE id = 25");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AM', country_iso3_code = 'ARM' WHERE id = 26");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AW', country_iso3_code = 'ABW' WHERE id = 27");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AU', country_iso3_code = 'AUS' WHERE id = 28");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AT', country_iso3_code = 'AUT' WHERE id = 29");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AZ', country_iso3_code = 'AZE' WHERE id = 30");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BS', country_iso3_code = 'BHS' WHERE id = 31");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BH', country_iso3_code = 'BHR' WHERE id = 32");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BD', country_iso3_code = 'BGD' WHERE id = 33");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BB', country_iso3_code = 'BRB' WHERE id = 34");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BY', country_iso3_code = 'BLR' WHERE id = 35");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BE', country_iso3_code = 'BEL' WHERE id = 36");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BZ', country_iso3_code = 'BLZ' WHERE id = 37");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BJ', country_iso3_code = 'BEN' WHERE id = 38");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BM', country_iso3_code = 'BMU' WHERE id = 39");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BT', country_iso3_code = 'BTN' WHERE id = 40");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BO', country_iso3_code = 'BOL' WHERE id = 41");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BE', country_iso3_code = 'BES' WHERE id = 42");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BA', country_iso3_code = 'BIH' WHERE id = 43");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BW', country_iso3_code = 'BWA' WHERE id = 44");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BV', country_iso3_code = 'BVT' WHERE id = 45");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BR', country_iso3_code = 'BRA' WHERE id = 46");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IO', country_iso3_code = 'IOT' WHERE id = 47");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BN', country_iso3_code = 'BRN' WHERE id = 48");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BG', country_iso3_code = 'BGR' WHERE id = 49");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BF', country_iso3_code = 'BFA' WHERE id = 50");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BI', country_iso3_code = 'BDI' WHERE id = 51");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KH', country_iso3_code = 'KHM' WHERE id = 52");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CM', country_iso3_code = 'CMR' WHERE id = 53");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CV', country_iso3_code = 'CPV' WHERE id = 54");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KY', country_iso3_code = 'CYM' WHERE id = 55");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CF', country_iso3_code = 'CAF' WHERE id = 56");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TD', country_iso3_code = 'TCD' WHERE id = 57");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CL', country_iso3_code = 'CHL' WHERE id = 58");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CN', country_iso3_code = 'CHN' WHERE id = 59");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'AU', country_iso3_code = 'AUS' WHERE id = 60");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CC', country_iso3_code = 'CCK' WHERE id = 61");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CO', country_iso3_code = 'COL' WHERE id = 62");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KM', country_iso3_code = 'COM' WHERE id = 63");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CG', country_iso3_code = 'COG' WHERE id = 64");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CD', country_iso3_code = 'COD' WHERE id = 65");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CK', country_iso3_code = 'COK' WHERE id = 66");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CR', country_iso3_code = 'CRI' WHERE id = 67");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CI', country_iso3_code = 'CIV' WHERE id = 68");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HR', country_iso3_code = 'HRV' WHERE id = 69");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CU', country_iso3_code = 'CUB' WHERE id = 70");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CW', country_iso3_code = 'CUW' WHERE id = 71");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CY', country_iso3_code = 'CYP' WHERE id = 72");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CZ', country_iso3_code = 'CZE' WHERE id = 73");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DK', country_iso3_code = 'DNK' WHERE id = 74");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DJ', country_iso3_code = 'DJI' WHERE id = 75");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DM', country_iso3_code = 'DMA' WHERE id = 76");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DO', country_iso3_code = 'DOM' WHERE id = 77");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'EC', country_iso3_code = 'ECU' WHERE id = 78");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SV', country_iso3_code = 'SLV' WHERE id = 79");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GQ', country_iso3_code = 'GNQ' WHERE id = 80");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ER', country_iso3_code = 'ERI' WHERE id = 81");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'EE', country_iso3_code = 'EST' WHERE id = 82");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ET', country_iso3_code = 'ETH' WHERE id = 83");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'FK', country_iso3_code = 'FLK' WHERE id = 84");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'FO', country_iso3_code = 'FRO' WHERE id = 85");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'FJ', country_iso3_code = 'FJI' WHERE id = 86");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'FI', country_iso3_code = 'FIN' WHERE id = 87");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'FR', country_iso3_code = 'FRA' WHERE id = 88");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GF', country_iso3_code = 'GUF' WHERE id = 89");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PF', country_iso3_code = 'PYF' WHERE id = 90");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TF', country_iso3_code = 'ATF' WHERE id = 91");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GA', country_iso3_code = 'GAB' WHERE id = 92");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GM', country_iso3_code = 'GMB' WHERE id = 93");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GE', country_iso3_code = 'GEO' WHERE id = 94");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'DE', country_iso3_code = 'DEU' WHERE id = 95");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GH', country_iso3_code = 'GHA' WHERE id = 96");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GI', country_iso3_code = 'GIB' WHERE id = 97");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GR', country_iso3_code = 'GRC' WHERE id = 98");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GL', country_iso3_code = 'GRL' WHERE id = 99");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GD', country_iso3_code = 'GRD' WHERE id = 100");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GP', country_iso3_code = 'GLP' WHERE id = 101");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GT', country_iso3_code = 'GTM' WHERE id = 102");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GG', country_iso3_code = 'GGY' WHERE id = 103");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GN', country_iso3_code = 'GIN' WHERE id = 104");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GW', country_iso3_code = 'GNB' WHERE id = 105");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'GY', country_iso3_code = 'GUY' WHERE id = 106");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HT', country_iso3_code = 'HTI' WHERE id = 107");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HM', country_iso3_code = 'HMD' WHERE id = 108");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VA', country_iso3_code = 'VAT' WHERE id = 109");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HN', country_iso3_code = 'HND' WHERE id = 110");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HU', country_iso3_code = 'HUN' WHERE id = 111");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IS', country_iso3_code = 'ISL' WHERE id = 112");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ID', country_iso3_code = 'IDN' WHERE id = 113");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IE', country_iso3_code = 'IRL' WHERE id = 114");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IM', country_iso3_code = 'IMN' WHERE id = 115");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IL', country_iso3_code = 'ISR' WHERE id = 116");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'IT', country_iso3_code = 'ITA' WHERE id = 117");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'JM', country_iso3_code = 'JAM' WHERE id = 118");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'JP', country_iso3_code = 'JPN' WHERE id = 119");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'JE', country_iso3_code = 'JEY' WHERE id = 120");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KZ', country_iso3_code = 'KAZ' WHERE id = 121");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KE', country_iso3_code = 'KEN' WHERE id = 122");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KI', country_iso3_code = 'KIR' WHERE id = 123");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KP', country_iso3_code = 'PRK' WHERE id = 124");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KR', country_iso3_code = 'KOR' WHERE id = 125");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KG', country_iso3_code = 'KGZ' WHERE id = 126");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LA', country_iso3_code = 'LAO' WHERE id = 127");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LV', country_iso3_code = 'LVA' WHERE id = 128");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LS', country_iso3_code = 'LSO' WHERE id = 129");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LR', country_iso3_code = 'LBR' WHERE id = 130");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LY', country_iso3_code = 'LBY' WHERE id = 131");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LI', country_iso3_code = 'LIE' WHERE id = 132");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LT', country_iso3_code = 'LTU' WHERE id = 133");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LU', country_iso3_code = 'LUX' WHERE id = 134");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MO', country_iso3_code = 'MAC' WHERE id = 135");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MK', country_iso3_code = 'MKD' WHERE id = 136");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MG', country_iso3_code = 'MDG' WHERE id = 137");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MW', country_iso3_code = 'MWI' WHERE id = 138");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MY', country_iso3_code = 'MYS' WHERE id = 139");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MV', country_iso3_code = 'MDV' WHERE id = 140");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ML', country_iso3_code = 'MLI' WHERE id = 141");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MT', country_iso3_code = 'MLT' WHERE id = 142");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MQ', country_iso3_code = 'MTQ' WHERE id = 143");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MR', country_iso3_code = 'MRT' WHERE id = 144");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MU', country_iso3_code = 'MUS' WHERE id = 145");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'YT', country_iso3_code = 'MYT' WHERE id = 146");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MX', country_iso3_code = 'MEX' WHERE id = 147");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MD', country_iso3_code = 'MDA' WHERE id = 148");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MC', country_iso3_code = 'MCO' WHERE id = 149");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MN', country_iso3_code = 'MNG' WHERE id = 150");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ME', country_iso3_code = 'MNE' WHERE id = 151");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MS', country_iso3_code = 'MSR' WHERE id = 152");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MA', country_iso3_code = 'MAR' WHERE id = 153");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MZ', country_iso3_code = 'MOZ' WHERE id = 154");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MM', country_iso3_code = 'MMR' WHERE id = 155");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NA', country_iso3_code = 'NAM' WHERE id = 156");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NR', country_iso3_code = 'NRU' WHERE id = 157");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NP', country_iso3_code = 'NPL' WHERE id = 158");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NL', country_iso3_code = 'NLD' WHERE id = 159");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NC', country_iso3_code = 'NCL' WHERE id = 160");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NZ', country_iso3_code = 'NZL' WHERE id = 161");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NI', country_iso3_code = 'NIC' WHERE id = 162");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NE', country_iso3_code = 'NER' WHERE id = 163");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NG', country_iso3_code = 'NGA' WHERE id = 164");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NU', country_iso3_code = 'NIU' WHERE id = 165");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NF', country_iso3_code = 'NFK' WHERE id = 166");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NO', country_iso3_code = 'NOR' WHERE id = 167");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'OM', country_iso3_code = 'OMN' WHERE id = 168");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PS', country_iso3_code = 'PSE' WHERE id = 169");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PA', country_iso3_code = 'PAN' WHERE id = 170");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PG', country_iso3_code = 'PNG' WHERE id = 171");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PY', country_iso3_code = 'PRY' WHERE id = 172");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PE', country_iso3_code = 'PER' WHERE id = 173");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PH', country_iso3_code = 'PHL' WHERE id = 174");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NZ', country_iso3_code = 'NZL' WHERE id = 175");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PL', country_iso3_code = 'POL' WHERE id = 176");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PT', country_iso3_code = 'PRT' WHERE id = 177");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'QA', country_iso3_code = 'QAT' WHERE id = 178");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'YT', country_iso3_code = 'MYT' WHERE id = 179");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'RO', country_iso3_code = 'ROU' WHERE id = 180");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'RU', country_iso3_code = 'RUS' WHERE id = 181");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'RW', country_iso3_code = 'RWA' WHERE id = 182");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'BL', country_iso3_code = 'BLM' WHERE id = 183");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SH', country_iso3_code = 'SHN' WHERE id = 184");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'KN', country_iso3_code = 'KNA' WHERE id = 185");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LC', country_iso3_code = 'LCA' WHERE id = 186");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MA', country_iso3_code = 'MAF' WHERE id = 187");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'PM', country_iso3_code = 'SPM' WHERE id = 188");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VC', country_iso3_code = 'VCT' WHERE id = 189");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'WS', country_iso3_code = 'WSM' WHERE id = 190");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SM', country_iso3_code = 'SMR' WHERE id = 191");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ST', country_iso3_code = 'STP' WHERE id = 192");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SN', country_iso3_code = 'SEN' WHERE id = 193");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'RS', country_iso3_code = 'SRB' WHERE id = 194");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SC', country_iso3_code = 'SYC' WHERE id = 195");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SL', country_iso3_code = 'SLE' WHERE id = 196");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SG', country_iso3_code = 'SGP' WHERE id = 197");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SX', country_iso3_code = 'SXM' WHERE id = 198");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SK', country_iso3_code = 'SVK' WHERE id = 199");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SI', country_iso3_code = 'SVN' WHERE id = 200");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SB', country_iso3_code = 'SLB' WHERE id = 201");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SO', country_iso3_code = 'SOM' WHERE id = 202");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ZA', country_iso3_code = 'ZAF' WHERE id = 203");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SG', country_iso3_code = 'SGS' WHERE id = 204");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SS', country_iso3_code = 'SSD' WHERE id = 205");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ES', country_iso3_code = 'ESP' WHERE id = 206");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'LK', country_iso3_code = 'LKA' WHERE id = 207");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SR', country_iso3_code = 'SUR' WHERE id = 208");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'NO', country_iso3_code = 'NOR' WHERE id = 209");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SZ', country_iso3_code = 'SWZ' WHERE id = 210");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'SE', country_iso3_code = 'SWE' WHERE id = 211");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'CH', country_iso3_code = 'CHE' WHERE id = 212");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TW', country_iso3_code = 'TWN' WHERE id = 213");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TJ', country_iso3_code = 'TJK' WHERE id = 214");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TZ', country_iso3_code = 'TZA' WHERE id = 215");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TH', country_iso3_code = 'THA' WHERE id = 216");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TL', country_iso3_code = 'TLS' WHERE id = 217");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TG', country_iso3_code = 'TGO' WHERE id = 218");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TK', country_iso3_code = 'TKL' WHERE id = 219");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TO', country_iso3_code = 'TON' WHERE id = 220");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TT', country_iso3_code = 'TTO' WHERE id = 221");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TN', country_iso3_code = 'TUN' WHERE id = 222");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TR', country_iso3_code = 'TUR' WHERE id = 223");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TM', country_iso3_code = 'TKM' WHERE id = 224");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TC', country_iso3_code = 'TCA' WHERE id = 225");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'TV', country_iso3_code = 'TUV' WHERE id = 226");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UG', country_iso3_code = 'UGA' WHERE id = 227");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UA', country_iso3_code = 'UKR' WHERE id = 228");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UY', country_iso3_code = 'URY' WHERE id = 229");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'UZ', country_iso3_code = 'UZB' WHERE id = 230");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VU', country_iso3_code = 'VUT' WHERE id = 231");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VE', country_iso3_code = 'VEN' WHERE id = 232");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VN', country_iso3_code = 'VNM' WHERE id = 233");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'VG', country_iso3_code = 'VGB' WHERE id = 234");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'WF', country_iso3_code = 'WLF' WHERE id = 235");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'MA', country_iso3_code = 'MAR' WHERE id = 236");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'YE', country_iso3_code = 'YEM' WHERE id = 237");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ZM', country_iso3_code = 'ZMB' WHERE id = 238");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'ZW', country_iso3_code = 'ZWE' WHERE id = 239");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'HK', country_iso3_code = 'HKG' WHERE id = 240");
            migrationBuilder.Sql(
                "UPDATE dictionaries.countries_of_residence SET country_iso2_code = 'XK', country_iso3_code = 'XKX' WHERE id = 241");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "country_phone_codes");

            migrationBuilder.DropColumn(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "country_phone_codes");

            migrationBuilder.DropColumn(
                name: "country_iso2_code",
                schema: "dictionaries",
                table: "countries_of_residence");

            migrationBuilder.DropColumn(
                name: "country_iso3_code",
                schema: "dictionaries",
                table: "countries_of_residence");
        }
    }
}
