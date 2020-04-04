using System.Collections.Generic;
using MAVN.Service.Dictionaries.MsSqlRepositories.Entities;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Contexts
{
    internal static class InitialData
    {
        internal static IReadOnlyList<CountryOfResidenceEntity> GetCountriesOrResidence()
            => new[]
            {
                new CountryOfResidenceEntity
                {
                    Id = 1,
                    Name = "United Arab Emirates",
                    CountryIso2Code = "AE",
                    CountryIso3Code = "ARE",
                    IsAvailable = true,
                    Order = 1
                },
                new CountryOfResidenceEntity
                {
                    Id = 2,
                    Name = "India",
                    CountryIso2Code = "IN",
                    CountryIso3Code = "IND",
                    IsAvailable = true,
                    Order = 2
                },
                new CountryOfResidenceEntity
                {
                    Id = 3,
                    Name = "Saudi Arabia",
                    CountryIso2Code = "SA",
                    CountryIso3Code = "SAU",
                    IsAvailable = true,
                    Order = 3
                },
                new CountryOfResidenceEntity
                {
                    Id = 4,
                    Name = "Pakistan",
                    CountryIso2Code = "PK",
                    CountryIso3Code = "PAK",
                    IsAvailable = true,
                    Order = 4
                },
                new CountryOfResidenceEntity
                {
                    Id = 5,
                    Name = "Jordan",
                    CountryIso2Code = "JO",
                    CountryIso3Code = "JOR",
                    IsAvailable = true,
                    Order = 5
                },
                new CountryOfResidenceEntity
                {
                    Id = 6,
                    Name = "United Kingdom",
                    CountryIso2Code = "GB",
                    CountryIso3Code = "GBR",
                    IsAvailable = true,
                    Order = 6
                },
                new CountryOfResidenceEntity
                {
                    Id = 7,
                    Name = "Egypt",
                    CountryIso2Code = "EG",
                    CountryIso3Code = "EGY",
                    IsAvailable = true,
                    Order = 7
                },
                new CountryOfResidenceEntity
                {
                    Id = 8,
                    Name = "Syrian Arab Republic",
                    CountryIso2Code = "SY",
                    CountryIso3Code = "SYR",
                    IsAvailable = true,
                    Order = 8
                },
                new CountryOfResidenceEntity
                {
                    Id = 9,
                    Name = "Canada",
                    CountryIso2Code = "CA",
                    CountryIso3Code = "CAN",
                    IsAvailable = true,
                    Order = 9
                },
                new CountryOfResidenceEntity
                {
                    Id = 10,
                    Name = "Lebanon",
                    CountryIso2Code = "LB",
                    CountryIso3Code = "LBN",
                    IsAvailable = true,
                    Order = 10
                },
                new CountryOfResidenceEntity
                {
                    Id = 11,
                    Name = "Sudan",
                    CountryIso2Code = "SD",
                    CountryIso3Code = "SDN",
                    IsAvailable = true,
                    Order = 11
                },
                new CountryOfResidenceEntity
                {
                    Id = 12,
                    Name = "United States",
                    CountryIso2Code = "US",
                    CountryIso3Code = "USA",
                    IsAvailable = true,
                    Order = 12
                },
                new CountryOfResidenceEntity
                {
                    Id = 13,
                    Name = "Kuwait",
                    CountryIso2Code = "KW",
                    CountryIso3Code = "KWT",
                    IsAvailable = true,
                    Order = 13
                },
                new CountryOfResidenceEntity
                {
                    Id = 14,
                    Name = "Iran, Islamic Republic of",
                    CountryIso2Code = "IR",
                    CountryIso3Code = "IRN",
                    IsAvailable = true,
                    Order = 14
                },
                new CountryOfResidenceEntity
                {
                    Id = 15,
                    Name = "Iraq",
                    CountryIso2Code = "IQ",
                    CountryIso3Code = "IRQ",
                    IsAvailable = true,
                    Order = 15
                },
                new CountryOfResidenceEntity
                {
                    Id = 16,
                    Name = "Afghanistan",
                    CountryIso2Code = "AF",
                    CountryIso3Code = "AFG",
                    IsAvailable = true,
                    Order = 16
                },
                new CountryOfResidenceEntity
                {
                    Id = 17,
                    Name = "Aland Islands",
                    CountryIso2Code = "AX",
                    CountryIso3Code = "ALA",
                    IsAvailable = true,
                    Order = 17
                },
                new CountryOfResidenceEntity
                {
                    Id = 18,
                    Name = "Albania",
                    CountryIso2Code = "AL",
                    CountryIso3Code = "ALB",
                    IsAvailable = true,
                    Order = 18
                },
                new CountryOfResidenceEntity
                {
                    Id = 19,
                    Name = "Algeria",
                    CountryIso2Code = "DZ",
                    CountryIso3Code = "DZA",
                    IsAvailable = true,
                    Order = 19
                },
                new CountryOfResidenceEntity
                {
                    Id = 20,
                    Name = "Andorra",
                    CountryIso2Code = "AD",
                    CountryIso3Code = "AND",
                    IsAvailable = true,
                    Order = 20
                },
                new CountryOfResidenceEntity
                {
                    Id = 21,
                    Name = "Angola",
                    CountryIso2Code = "AO",
                    CountryIso3Code = "AGO",
                    IsAvailable = true,
                    Order = 21
                },
                new CountryOfResidenceEntity
                {
                    Id = 22,
                    Name = "Anguilla",
                    CountryIso2Code = "AI",
                    CountryIso3Code = "AIA",
                    IsAvailable = true,
                    Order = 22
                },
                new CountryOfResidenceEntity
                {
                    Id = 23,
                    Name = "Antarctica",
                    CountryIso2Code = "AQ",
                    CountryIso3Code = "ATA",
                    IsAvailable = true,
                    Order = 23
                },
                new CountryOfResidenceEntity
                {
                    Id = 24,
                    Name = "Antigua and Barbuda",
                    CountryIso2Code = "AG",
                    CountryIso3Code = "ATG",
                    IsAvailable = true,
                    Order = 24
                },
                new CountryOfResidenceEntity
                {
                    Id = 25,
                    Name = "Argentina",
                    CountryIso2Code = "AR",
                    CountryIso3Code = "ARG",
                    IsAvailable = true,
                    Order = 25
                },
                new CountryOfResidenceEntity
                {
                    Id = 26,
                    Name = "Armenia",
                    CountryIso2Code = "AM",
                    CountryIso3Code = "ARM",
                    IsAvailable = true,
                    Order = 26
                },
                new CountryOfResidenceEntity
                {
                    Id = 27,
                    Name = "Aruba",
                    CountryIso2Code = "AW",
                    CountryIso3Code = "ABW",
                    IsAvailable = true,
                    Order = 27
                },
                new CountryOfResidenceEntity
                {
                    Id = 28,
                    Name = "Australia",
                    CountryIso2Code = "AU",
                    CountryIso3Code = "AUS",
                    IsAvailable = true,
                    Order = 28
                },
                new CountryOfResidenceEntity
                {
                    Id = 29,
                    Name = "Austria",
                    CountryIso2Code = "AT",
                    CountryIso3Code = "AUT",
                    IsAvailable = true,
                    Order = 29
                },
                new CountryOfResidenceEntity
                {
                    Id = 30,
                    Name = "Azerbaijan",
                    CountryIso2Code = "AZ",
                    CountryIso3Code = "AZE",
                    IsAvailable = true,
                    Order = 30
                },
                new CountryOfResidenceEntity
                {
                    Id = 31,
                    Name = "Bahamas",
                    CountryIso2Code = "BS",
                    CountryIso3Code = "BHS",
                    IsAvailable = true,
                    Order = 31
                },
                new CountryOfResidenceEntity
                {
                    Id = 32,
                    Name = "Bahrain",
                    CountryIso2Code = "BH",
                    CountryIso3Code = "BHR",
                    IsAvailable = true,
                    Order = 32
                },
                new CountryOfResidenceEntity
                {
                    Id = 33,
                    Name = "Bangladesh",
                    CountryIso2Code = "BD",
                    CountryIso3Code = "BGD",
                    IsAvailable = true,
                    Order = 33
                },
                new CountryOfResidenceEntity
                {
                    Id = 34,
                    Name = "Barbados",
                    CountryIso2Code = "BB",
                    CountryIso3Code = "BRB",
                    IsAvailable = true,
                    Order = 34
                },
                new CountryOfResidenceEntity
                {
                    Id = 35,
                    Name = "Belarus",
                    CountryIso2Code = "BY",
                    CountryIso3Code = "BLR",
                    IsAvailable = true,
                    Order = 35
                },
                new CountryOfResidenceEntity
                {
                    Id = 36,
                    Name = "Belgium",
                    CountryIso2Code = "BE",
                    CountryIso3Code = "BEL",
                    IsAvailable = true,
                    Order = 36
                },
                new CountryOfResidenceEntity
                {
                    Id = 37,
                    Name = "Belize",
                    CountryIso2Code = "BZ",
                    CountryIso3Code = "BLZ",
                    IsAvailable = true,
                    Order = 37
                },
                new CountryOfResidenceEntity
                {
                    Id = 38,
                    Name = "Benin",
                    CountryIso2Code = "BJ",
                    CountryIso3Code = "BEN",
                    IsAvailable = true,
                    Order = 38
                },
                new CountryOfResidenceEntity
                {
                    Id = 39,
                    Name = "Bermuda",
                    CountryIso2Code = "BM",
                    CountryIso3Code = "BMU",
                    IsAvailable = true,
                    Order = 39
                },
                new CountryOfResidenceEntity
                {
                    Id = 40,
                    Name = "Bhutan",
                    CountryIso2Code = "BT",
                    CountryIso3Code = "BTN",
                    IsAvailable = true,
                    Order = 40
                },
                new CountryOfResidenceEntity
                {
                    Id = 41,
                    Name = "Bolivia, Plurinational State of",
                    CountryIso2Code = "BO",
                    CountryIso3Code = "BOL",
                    IsAvailable = true,
                    Order = 41
                },
                new CountryOfResidenceEntity
                {
                    Id = 42,
                    Name = "Bonaire, Sint Eustatius and Saba",
                    CountryIso2Code = "BQ",
                    CountryIso3Code = "BES",
                    IsAvailable = true,
                    Order = 42
                },
                new CountryOfResidenceEntity
                {
                    Id = 43,
                    Name = "Bosnia and Herzegovina",
                    CountryIso2Code = "BA",
                    CountryIso3Code = "BIH",
                    IsAvailable = true,
                    Order = 43
                },
                new CountryOfResidenceEntity
                {
                    Id = 44,
                    Name = "Botswana",
                    CountryIso2Code = "BW",
                    CountryIso3Code = "BWA",
                    IsAvailable = true,
                    Order = 44
                },
                new CountryOfResidenceEntity
                {
                    Id = 45,
                    Name = "Bouvet Island",
                    CountryIso2Code = "BV",
                    CountryIso3Code = "BVT",
                    IsAvailable = true,
                    Order = 45
                },
                new CountryOfResidenceEntity
                {
                    Id = 46,
                    Name = "Brazil",
                    CountryIso2Code = "BR",
                    CountryIso3Code = "BRA",
                    IsAvailable = true,
                    Order = 46
                },
                new CountryOfResidenceEntity
                {
                    Id = 47,
                    Name = "British Indian Ocean Territory",
                    CountryIso2Code = "IO",
                    CountryIso3Code = "IOT",
                    IsAvailable = true,
                    Order = 47
                },
                new CountryOfResidenceEntity
                {
                    Id = 48,
                    Name = "Brunei Darussalam",
                    CountryIso2Code = "BN",
                    CountryIso3Code = "BRN",
                    IsAvailable = true,
                    Order = 48
                },
                new CountryOfResidenceEntity
                {
                    Id = 49,
                    Name = "Bulgaria",
                    CountryIso2Code = "BG",
                    CountryIso3Code = "BGR",
                    IsAvailable = true,
                    Order = 49
                },
                new CountryOfResidenceEntity
                {
                    Id = 50,
                    Name = "Burkina Faso",
                    CountryIso2Code = "BF",
                    CountryIso3Code = "BFA",
                    IsAvailable = true,
                    Order = 50
                },
                new CountryOfResidenceEntity
                {
                    Id = 51,
                    Name = "Burundi",
                    CountryIso2Code = "BI",
                    CountryIso3Code = "BDI",
                    IsAvailable = true,
                    Order = 51
                },
                new CountryOfResidenceEntity
                {
                    Id = 52,
                    Name = "Cambodia",
                    CountryIso2Code = "KH",
                    CountryIso3Code = "KHM",
                    IsAvailable = true,
                    Order = 52
                },
                new CountryOfResidenceEntity
                {
                    Id = 53,
                    Name = "Cameroon",
                    CountryIso2Code = "CM",
                    CountryIso3Code = "CMR",
                    IsAvailable = true,
                    Order = 53
                },
                new CountryOfResidenceEntity
                {
                    Id = 54,
                    Name = "Cape Verde",
                    CountryIso2Code = "CV",
                    CountryIso3Code = "CPV",
                    IsAvailable = true,
                    Order = 54
                },
                new CountryOfResidenceEntity
                {
                    Id = 55,
                    Name = "Cayman Islands",
                    CountryIso2Code = "KY",
                    CountryIso3Code = "CYM",
                    IsAvailable = true,
                    Order = 55
                },
                new CountryOfResidenceEntity
                {
                    Id = 56,
                    Name = "Central African Republic",
                    CountryIso2Code = "CF",
                    CountryIso3Code = "CAF",
                    IsAvailable = true,
                    Order = 56
                },
                new CountryOfResidenceEntity
                {
                    Id = 57,
                    Name = "Chad",
                    CountryIso2Code = "TD",
                    CountryIso3Code = "TCD",
                    IsAvailable = true,
                    Order = 57
                },
                new CountryOfResidenceEntity
                {
                    Id = 58,
                    Name = "Chile",
                    CountryIso2Code = "CL",
                    CountryIso3Code = "CHL",
                    IsAvailable = true,
                    Order = 58
                },
                new CountryOfResidenceEntity
                {
                    Id = 59,
                    Name = "China",
                    CountryIso2Code = "CN",
                    CountryIso3Code = "CHN",
                    IsAvailable = true,
                    Order = 59
                },
                new CountryOfResidenceEntity
                {
                    Id = 60,
                    Name = "Christmas Island",
                    CountryIso2Code = "CX",
                    CountryIso3Code = "CXR",
                    IsAvailable = true,
                    Order = 60
                },
                new CountryOfResidenceEntity
                {
                    Id = 61,
                    Name = "Cocos (Keeling) Islands",
                    CountryIso2Code = "CC",
                    CountryIso3Code = "CCK",
                    IsAvailable = true,
                    Order = 61
                },
                new CountryOfResidenceEntity
                {
                    Id = 62,
                    Name = "Colombia",
                    CountryIso2Code = "CO",
                    CountryIso3Code = "COL",
                    IsAvailable = true,
                    Order = 62
                },
                new CountryOfResidenceEntity
                {
                    Id = 63,
                    Name = "Comoros",
                    CountryIso2Code = "KM",
                    CountryIso3Code = "COM",
                    IsAvailable = true,
                    Order = 63
                },
                new CountryOfResidenceEntity
                {
                    Id = 64,
                    Name = "Congo",
                    CountryIso2Code = "CG",
                    CountryIso3Code = "COG",
                    IsAvailable = true,
                    Order = 64
                },
                new CountryOfResidenceEntity
                {
                    Id = 65,
                    Name = "Congo, the Democratic Republic of the",
                    CountryIso2Code = "CD",
                    CountryIso3Code = "COD",
                    IsAvailable = true,
                    Order = 65
                },
                new CountryOfResidenceEntity
                {
                    Id = 66,
                    Name = "Cook Islands",
                    CountryIso2Code = "CK",
                    CountryIso3Code = "COK",
                    IsAvailable = true,
                    Order = 66
                },
                new CountryOfResidenceEntity
                {
                    Id = 67,
                    Name = "Costa Rica",
                    CountryIso2Code = "CR",
                    CountryIso3Code = "CRI",
                    IsAvailable = true,
                    Order = 67
                },
                new CountryOfResidenceEntity
                {
                    Id = 68,
                    Name = "Cote d''Ivoire",
                    CountryIso2Code = "CI",
                    CountryIso3Code = "CIV",
                    IsAvailable = true,
                    Order = 68
                },
                new CountryOfResidenceEntity
                {
                    Id = 69,
                    Name = "Croatia",
                    CountryIso2Code = "HR",
                    CountryIso3Code = "HRV",
                    IsAvailable = true,
                    Order = 69
                },
                new CountryOfResidenceEntity
                {
                    Id = 70,
                    Name = "Cuba",
                    CountryIso2Code = "CU",
                    CountryIso3Code = "CUB",
                    IsAvailable = true,
                    Order = 70
                },
                new CountryOfResidenceEntity
                {
                    Id = 71,
                    Name = "Curaçao",
                    CountryIso2Code = "CW",
                    CountryIso3Code = "CUW",
                    IsAvailable = true,
                    Order = 71
                },
                new CountryOfResidenceEntity
                {
                    Id = 72,
                    Name = "Cyprus",
                    CountryIso2Code = "CY",
                    CountryIso3Code = "CYP",
                    IsAvailable = true,
                    Order = 72
                },
                new CountryOfResidenceEntity
                {
                    Id = 73,
                    Name = "Czech Republic",
                    CountryIso2Code = "CZ",
                    CountryIso3Code = "CZE",
                    IsAvailable = true,
                    Order = 73
                },
                new CountryOfResidenceEntity
                {
                    Id = 74,
                    Name = "Denmark",
                    CountryIso2Code = "DK",
                    CountryIso3Code = "DNK",
                    IsAvailable = true,
                    Order = 74
                },
                new CountryOfResidenceEntity
                {
                    Id = 75,
                    Name = "Djibouti",
                    CountryIso2Code = "DJ",
                    CountryIso3Code = "DJI",
                    IsAvailable = true,
                    Order = 75
                },
                new CountryOfResidenceEntity
                {
                    Id = 76,
                    Name = "Dominica",
                    CountryIso2Code = "DM",
                    CountryIso3Code = "DMA",
                    IsAvailable = true,
                    Order = 76
                },
                new CountryOfResidenceEntity
                {
                    Id = 77,
                    Name = "Dominican Republic",
                    CountryIso2Code = "DO",
                    CountryIso3Code = "DOM",
                    IsAvailable = true,
                    Order = 77
                },
                new CountryOfResidenceEntity
                {
                    Id = 78,
                    Name = "Ecuador",
                    CountryIso2Code = "EC",
                    CountryIso3Code = "ECU",
                    IsAvailable = true,
                    Order = 78
                },
                new CountryOfResidenceEntity
                {
                    Id = 79,
                    Name = "El Salvador",
                    CountryIso2Code = "SV",
                    CountryIso3Code = "SLV",
                    IsAvailable = true,
                    Order = 79
                },
                new CountryOfResidenceEntity
                {
                    Id = 80,
                    Name = "Equatorial Guinea",
                    CountryIso2Code = "GQ",
                    CountryIso3Code = "GNQ",
                    IsAvailable = true,
                    Order = 80
                },
                new CountryOfResidenceEntity
                {
                    Id = 81,
                    Name = "Eritrea",
                    CountryIso2Code = "ER",
                    CountryIso3Code = "ERI",
                    IsAvailable = true,
                    Order = 81
                },
                new CountryOfResidenceEntity
                {
                    Id = 82,
                    Name = "Estonia",
                    CountryIso2Code = "EE",
                    CountryIso3Code = "EST",
                    IsAvailable = true,
                    Order = 82
                },
                new CountryOfResidenceEntity
                {
                    Id = 83,
                    Name = "Ethiopia",
                    CountryIso2Code = "ET",
                    CountryIso3Code = "ETH",
                    IsAvailable = true,
                    Order = 83
                },
                new CountryOfResidenceEntity
                {
                    Id = 84,
                    Name = "Falkland Islands (Malvinas)",
                    CountryIso2Code = "FK",
                    CountryIso3Code = "FLK",
                    IsAvailable = true,
                    Order = 84
                },
                new CountryOfResidenceEntity
                {
                    Id = 85,
                    Name = "Faroe Islands",
                    CountryIso2Code = "FO",
                    CountryIso3Code = "FRO",
                    IsAvailable = true,
                    Order = 85
                },
                new CountryOfResidenceEntity
                {
                    Id = 86,
                    Name = "Fiji",
                    CountryIso2Code = "FJ",
                    CountryIso3Code = "FJI",
                    IsAvailable = true,
                    Order = 86
                },
                new CountryOfResidenceEntity
                {
                    Id = 87,
                    Name = "Finland",
                    CountryIso2Code = "FI",
                    CountryIso3Code = "FIN",
                    IsAvailable = true,
                    Order = 87
                },
                new CountryOfResidenceEntity
                {
                    Id = 88,
                    Name = "France",
                    CountryIso2Code = "FR",
                    CountryIso3Code = "FRA",
                    IsAvailable = true,
                    Order = 88
                },
                new CountryOfResidenceEntity
                {
                    Id = 89,
                    Name = "French Guiana",
                    CountryIso2Code = "GF",
                    CountryIso3Code = "GUF",
                    IsAvailable = true,
                    Order = 89
                },
                new CountryOfResidenceEntity
                {
                    Id = 90,
                    Name = "French Polynesia",
                    CountryIso2Code = "PF",
                    CountryIso3Code = "PYF",
                    IsAvailable = true,
                    Order = 90
                },
                new CountryOfResidenceEntity
                {
                    Id = 91,
                    Name = "French Southern Territories",
                    CountryIso2Code = "FQ",
                    CountryIso3Code = "ATF",
                    IsAvailable = true,
                    Order = 91
                },
                new CountryOfResidenceEntity
                {
                    Id = 92,
                    Name = "Gabon",
                    CountryIso2Code = "GA",
                    CountryIso3Code = "GAB",
                    IsAvailable = true,
                    Order = 92
                },
                new CountryOfResidenceEntity
                {
                    Id = 93,
                    Name = "Gambia",
                    CountryIso2Code = "GM",
                    CountryIso3Code = "GMB",
                    IsAvailable = true,
                    Order = 93
                },
                new CountryOfResidenceEntity
                {
                    Id = 94,
                    Name = "Georgia",
                    CountryIso2Code = "GE",
                    CountryIso3Code = "GEO",
                    IsAvailable = true,
                    Order = 94
                },
                new CountryOfResidenceEntity
                {
                    Id = 95,
                    Name = "Germany",
                    CountryIso2Code = "DE",
                    CountryIso3Code = "DEU",
                    IsAvailable = true,
                    Order = 95
                },
                new CountryOfResidenceEntity
                {
                    Id = 96,
                    Name = "Ghana",
                    CountryIso2Code = "GH",
                    CountryIso3Code = "GHA",
                    IsAvailable = true,
                    Order = 96
                },
                new CountryOfResidenceEntity
                {
                    Id = 97,
                    Name = "Gibraltar",
                    CountryIso2Code = "GI",
                    CountryIso3Code = "GIB",
                    IsAvailable = true,
                    Order = 97
                },
                new CountryOfResidenceEntity
                {
                    Id = 98,
                    Name = "Greece",
                    CountryIso2Code = "GR",
                    CountryIso3Code = "GRC",
                    IsAvailable = true,
                    Order = 98
                },
                new CountryOfResidenceEntity
                {
                    Id = 99,
                    Name = "Greenland",
                    CountryIso2Code = "GL",
                    CountryIso3Code = "GRL",
                    IsAvailable = true,
                    Order = 99
                },
                new CountryOfResidenceEntity
                {
                    Id = 100,
                    Name = "Grenada",
                    CountryIso2Code = "GD",
                    CountryIso3Code = "GRD",
                    IsAvailable = true,
                    Order = 100
                },
                new CountryOfResidenceEntity
                {
                    Id = 101,
                    Name = "Guadeloupe",
                    CountryIso2Code = "GP",
                    CountryIso3Code = "GLP",
                    IsAvailable = true,
                    Order = 101
                },
                new CountryOfResidenceEntity
                {
                    Id = 102,
                    Name = "Guatemala",
                    CountryIso2Code = "GT",
                    CountryIso3Code = "GTM",
                    IsAvailable = true,
                    Order = 102
                },
                new CountryOfResidenceEntity
                {
                    Id = 103,
                    Name = "Guernsey",
                    CountryIso2Code = "GG",
                    CountryIso3Code = "GGY",
                    IsAvailable = true,
                    Order = 103
                },
                new CountryOfResidenceEntity
                {
                    Id = 104,
                    Name = "Guinea",
                    CountryIso2Code = "GN",
                    CountryIso3Code = "GIN",
                    IsAvailable = true,
                    Order = 104
                },
                new CountryOfResidenceEntity
                {
                    Id = 105,
                    Name = "Guinea-Bissau",
                    CountryIso2Code = "GW",
                    CountryIso3Code = "GNB",
                    IsAvailable = true,
                    Order = 105
                },
                new CountryOfResidenceEntity
                {
                    Id = 106,
                    Name = "Guyana",
                    CountryIso2Code = "GY",
                    CountryIso3Code = "GUY",
                    IsAvailable = true,
                    Order = 106
                },
                new CountryOfResidenceEntity
                {
                    Id = 107,
                    Name = "Haiti",
                    CountryIso2Code = "HT",
                    CountryIso3Code = "HTI",
                    IsAvailable = true,
                    Order = 107
                },
                new CountryOfResidenceEntity
                {
                    Id = 108,
                    Name = "Heard Island and McDonald Islands",
                    CountryIso2Code = "HM",
                    CountryIso3Code = "HMD",
                    IsAvailable = true,
                    Order = 108
                },
                new CountryOfResidenceEntity
                {
                    Id = 109,
                    Name = "Holy See (Vatican City State)",
                    CountryIso2Code = "VA",
                    CountryIso3Code = "VAT",
                    IsAvailable = true,
                    Order = 109
                },
                new CountryOfResidenceEntity
                {
                    Id = 110,
                    Name = "Honduras",
                    CountryIso2Code = "HN",
                    CountryIso3Code = "HND",
                    IsAvailable = true,
                    Order = 110
                },
                new CountryOfResidenceEntity
                {
                    Id = 111,
                    Name = "Hungary",
                    CountryIso2Code = "HU",
                    CountryIso3Code = "HUN",
                    IsAvailable = true,
                    Order = 111
                },
                new CountryOfResidenceEntity
                {
                    Id = 112,
                    Name = "Iceland",
                    CountryIso2Code = "IS",
                    CountryIso3Code = "ISL",
                    IsAvailable = true,
                    Order = 112
                },
                new CountryOfResidenceEntity
                {
                    Id = 113,
                    Name = "Indonesia",
                    CountryIso2Code = "ID",
                    CountryIso3Code = "IDN",
                    IsAvailable = true,
                    Order = 113
                },
                new CountryOfResidenceEntity
                {
                    Id = 114,
                    Name = "Ireland",
                    CountryIso2Code = "IE",
                    CountryIso3Code = "IRL",
                    IsAvailable = true,
                    Order = 114
                },
                new CountryOfResidenceEntity
                {
                    Id = 115,
                    Name = "Isle of Man",
                    CountryIso2Code = "IM",
                    CountryIso3Code = "IMN",
                    IsAvailable = true,
                    Order = 115
                },
                new CountryOfResidenceEntity
                {
                    Id = 116,
                    Name = "Israel",
                    CountryIso2Code = "IL",
                    CountryIso3Code = "ISR",
                    IsAvailable = true,
                    Order = 116
                },
                new CountryOfResidenceEntity
                {
                    Id = 117,
                    Name = "Italy",
                    CountryIso2Code = "IT",
                    CountryIso3Code = "ITA",
                    IsAvailable = true,
                    Order = 117
                },
                new CountryOfResidenceEntity
                {
                    Id = 118,
                    Name = "Jamaica",
                    CountryIso2Code = "JM",
                    CountryIso3Code = "JAM",
                    IsAvailable = true,
                    Order = 118
                },
                new CountryOfResidenceEntity
                {
                    Id = 119,
                    Name = "Japan",
                    CountryIso2Code = "JP",
                    CountryIso3Code = "JPN",
                    IsAvailable = true,
                    Order = 119
                },
                new CountryOfResidenceEntity
                {
                    Id = 120,
                    Name = "Jersey",
                    CountryIso2Code = "JE",
                    CountryIso3Code = "JEY",
                    IsAvailable = true,
                    Order = 120
                },
                new CountryOfResidenceEntity
                {
                    Id = 121,
                    Name = "Kazakhstan",
                    CountryIso2Code = "KZ",
                    CountryIso3Code = "KAZ",
                    IsAvailable = true,
                    Order = 121
                },
                new CountryOfResidenceEntity
                {
                    Id = 122,
                    Name = "Kenya",
                    CountryIso2Code = "KE",
                    CountryIso3Code = "KEN",
                    IsAvailable = true,
                    Order = 122
                },
                new CountryOfResidenceEntity
                {
                    Id = 123,
                    Name = "Kiribati",
                    CountryIso2Code = "KI",
                    CountryIso3Code = "KIR",
                    IsAvailable = true,
                    Order = 123
                },
                new CountryOfResidenceEntity
                {
                    Id = 124,
                    Name = "Korea, Democratic People's Republic of",
                    CountryIso2Code = "KP",
                    CountryIso3Code = "PRK",
                    IsAvailable = true,
                    Order = 124
                },
                new CountryOfResidenceEntity
                {
                    Id = 125,
                    Name = "Korea, Republic of",
                    CountryIso2Code = "KR",
                    CountryIso3Code = "KOR",
                    IsAvailable = true,
                    Order = 125
                },
                new CountryOfResidenceEntity
                {
                    Id = 126,
                    Name = "Kyrgyzstan",
                    CountryIso2Code = "KG",
                    CountryIso3Code = "KGZ",
                    IsAvailable = true,
                    Order = 126
                },
                new CountryOfResidenceEntity
                {
                    Id = 127,
                    Name = "Lao People's Democratic Republic",
                    CountryIso2Code = "LA",
                    CountryIso3Code = "LAO",
                    IsAvailable = true,
                    Order = 127
                },
                new CountryOfResidenceEntity
                {
                    Id = 128,
                    Name = "Latvia",
                    CountryIso2Code = "LV",
                    CountryIso3Code = "LVA",
                    IsAvailable = true,
                    Order = 128
                },
                new CountryOfResidenceEntity
                {
                    Id = 129,
                    Name = "Lesotho",
                    CountryIso2Code = "LS",
                    CountryIso3Code = "LSO",
                    IsAvailable = true,
                    Order = 129
                },
                new CountryOfResidenceEntity
                {
                    Id = 130,
                    Name = "Liberia",
                    CountryIso2Code = "LR",
                    CountryIso3Code = "LBR",
                    IsAvailable = true,
                    Order = 130
                },
                new CountryOfResidenceEntity
                {
                    Id = 131,
                    Name = "Libya",
                    CountryIso2Code = "LY",
                    CountryIso3Code = "LBY",
                    IsAvailable = true,
                    Order = 131
                },
                new CountryOfResidenceEntity
                {
                    Id = 132,
                    Name = "Liechtenstein",
                    CountryIso2Code = "LI",
                    CountryIso3Code = "LIE",
                    IsAvailable = true,
                    Order = 132
                },
                new CountryOfResidenceEntity
                {
                    Id = 133,
                    Name = "Lithuania",
                    CountryIso2Code = "LT",
                    CountryIso3Code = "LTU",
                    IsAvailable = true,
                    Order = 133
                },
                new CountryOfResidenceEntity
                {
                    Id = 134,
                    Name = "Luxembourg",
                    CountryIso2Code = "LU",
                    CountryIso3Code = "LUX",
                    IsAvailable = true,
                    Order = 134
                },
                new CountryOfResidenceEntity
                {
                    Id = 135,
                    Name = "Macao",
                    CountryIso2Code = "MO",
                    CountryIso3Code = "MAC",
                    IsAvailable = true,
                    Order = 135
                },
                new CountryOfResidenceEntity
                {
                    Id = 136,
                    Name = "Macedonia, the former Yugoslav Republic of",
                    CountryIso2Code = "MK",
                    CountryIso3Code = "MKD",
                    IsAvailable = true,
                    Order = 136
                },
                new CountryOfResidenceEntity
                {
                    Id = 137,
                    Name = "Madagascar",
                    CountryIso2Code = "MG",
                    CountryIso3Code = "MDG",
                    IsAvailable = true,
                    Order = 137
                },
                new CountryOfResidenceEntity
                {
                    Id = 138,
                    Name = "Malawi",
                    CountryIso2Code = "MW",
                    CountryIso3Code = "MWI",
                    IsAvailable = true,
                    Order = 138
                },
                new CountryOfResidenceEntity
                {
                    Id = 139,
                    Name = "Malaysia",
                    CountryIso2Code = "MY",
                    CountryIso3Code = "MYS",
                    IsAvailable = true,
                    Order = 139
                },
                new CountryOfResidenceEntity
                {
                    Id = 140,
                    Name = "Maldives",
                    CountryIso2Code = "MV",
                    CountryIso3Code = "MDV",
                    IsAvailable = true,
                    Order = 140
                },
                new CountryOfResidenceEntity
                {
                    Id = 141,
                    Name = "Mali",
                    CountryIso2Code = "ML",
                    CountryIso3Code = "MLI",
                    IsAvailable = true,
                    Order = 141
                },
                new CountryOfResidenceEntity
                {
                    Id = 142,
                    Name = "Malta",
                    CountryIso2Code = "MT",
                    CountryIso3Code = "MLT",
                    IsAvailable = true,
                    Order = 142
                },
                new CountryOfResidenceEntity
                {
                    Id = 143,
                    Name = "Martinique",
                    CountryIso2Code = "MQ",
                    CountryIso3Code = "MTQ",
                    IsAvailable = true,
                    Order = 143
                },
                new CountryOfResidenceEntity
                {
                    Id = 144,
                    Name = "Mauritania",
                    CountryIso2Code = "MR",
                    CountryIso3Code = "MRT",
                    IsAvailable = true,
                    Order = 144
                },
                new CountryOfResidenceEntity
                {
                    Id = 145,
                    Name = "Mauritius",
                    CountryIso2Code = "MU",
                    CountryIso3Code = "MUS",
                    IsAvailable = true,
                    Order = 145
                },
                new CountryOfResidenceEntity
                {
                    Id = 146,
                    Name = "Mayotte",
                    CountryIso2Code = "YT",
                    CountryIso3Code = "MYT",
                    IsAvailable = true,
                    Order = 146
                },
                new CountryOfResidenceEntity
                {
                    Id = 147,
                    Name = "Mexico",
                    CountryIso2Code = "MX",
                    CountryIso3Code = "MEX",
                    IsAvailable = true,
                    Order = 147
                },
                new CountryOfResidenceEntity
                {
                    Id = 148,
                    Name = "Moldova, Republic of",
                    CountryIso2Code = "MD",
                    CountryIso3Code = "MDA",
                    IsAvailable = true,
                    Order = 148
                },
                new CountryOfResidenceEntity
                {
                    Id = 149,
                    Name = "Monaco",
                    CountryIso2Code = "MC",
                    CountryIso3Code = "MCO",
                    IsAvailable = true,
                    Order = 149
                },
                new CountryOfResidenceEntity
                {
                    Id = 150,
                    Name = "Mongolia",
                    CountryIso2Code = "MN",
                    CountryIso3Code = "MNG",
                    IsAvailable = true,
                    Order = 150
                },
                new CountryOfResidenceEntity
                {
                    Id = 151,
                    Name = "Montenegro",
                    CountryIso2Code = "ME",
                    CountryIso3Code = "MNE",
                    IsAvailable = true,
                    Order = 151
                },
                new CountryOfResidenceEntity
                {
                    Id = 152,
                    Name = "Montserrat",
                    CountryIso2Code = "MS",
                    CountryIso3Code = "MSR",
                    IsAvailable = true,
                    Order = 152
                },
                new CountryOfResidenceEntity
                {
                    Id = 153,
                    Name = "Morocco",
                    CountryIso2Code = "MA",
                    CountryIso3Code = "MAR",
                    IsAvailable = true,
                    Order = 153
                },
                new CountryOfResidenceEntity
                {
                    Id = 154,
                    Name = "Mozambique",
                    CountryIso2Code = "MZ",
                    CountryIso3Code = "MOZ",
                    IsAvailable = true,
                    Order = 154
                },
                new CountryOfResidenceEntity
                {
                    Id = 155,
                    Name = "Myanmar",
                    CountryIso2Code = "MM",
                    CountryIso3Code = "MMR",
                    IsAvailable = true,
                    Order = 155
                },
                new CountryOfResidenceEntity
                {
                    Id = 156,
                    Name = "Namibia",
                    CountryIso2Code = "NA",
                    CountryIso3Code = "NAM",
                    IsAvailable = true,
                    Order = 156
                },
                new CountryOfResidenceEntity
                {
                    Id = 157,
                    Name = "Nauru",
                    CountryIso2Code = "NR",
                    CountryIso3Code = "NRU",
                    IsAvailable = true,
                    Order = 157
                },
                new CountryOfResidenceEntity
                {
                    Id = 158,
                    Name = "Nepal",
                    CountryIso2Code = "NP",
                    CountryIso3Code = "NPL",
                    IsAvailable = true,
                    Order = 158
                },
                new CountryOfResidenceEntity
                {
                    Id = 159,
                    Name = "Netherlands",
                    CountryIso2Code = "NL",
                    CountryIso3Code = "NLD",
                    IsAvailable = true,
                    Order = 159
                },
                new CountryOfResidenceEntity
                {
                    Id = 160,
                    Name = "New Caledonia",
                    CountryIso2Code = "NC",
                    CountryIso3Code = "NCL",
                    IsAvailable = true,
                    Order = 160
                },
                new CountryOfResidenceEntity
                {
                    Id = 161,
                    Name = "New Zealand",
                    CountryIso2Code = "NZ",
                    CountryIso3Code = "NZL",
                    IsAvailable = true,
                    Order = 161
                },
                new CountryOfResidenceEntity
                {
                    Id = 162,
                    Name = "Nicaragua",
                    CountryIso2Code = "NI",
                    CountryIso3Code = "NIC",
                    IsAvailable = true,
                    Order = 162
                },
                new CountryOfResidenceEntity
                {
                    Id = 163,
                    Name = "Niger",
                    CountryIso2Code = "NE",
                    CountryIso3Code = "NER",
                    IsAvailable = true,
                    Order = 163
                },
                new CountryOfResidenceEntity
                {
                    Id = 164,
                    Name = "Nigeria",
                    CountryIso2Code = "NG",
                    CountryIso3Code = "NGA",
                    IsAvailable = true,
                    Order = 164
                },
                new CountryOfResidenceEntity
                {
                    Id = 165,
                    Name = "Niue",
                    CountryIso2Code = "NU",
                    CountryIso3Code = "NIU",
                    IsAvailable = true,
                    Order = 165
                },
                new CountryOfResidenceEntity
                {
                    Id = 166,
                    Name = "Norfolk Island",
                    CountryIso2Code = "NF",
                    CountryIso3Code = "NFK",
                    IsAvailable = true,
                    Order = 166
                },
                new CountryOfResidenceEntity
                {
                    Id = 167,
                    Name = "Norway",
                    CountryIso2Code = "NO",
                    CountryIso3Code = "NOR",
                    IsAvailable = true,
                    Order = 167
                },
                new CountryOfResidenceEntity
                {
                    Id = 168,
                    Name = "Oman",
                    CountryIso2Code = "OM",
                    CountryIso3Code = "OMN",
                    IsAvailable = true,
                    Order = 168
                },
                new CountryOfResidenceEntity
                {
                    Id = 169,
                    Name = "Palestine",
                    CountryIso2Code = "PS",
                    CountryIso3Code = "PSE",
                    IsAvailable = true,
                    Order = 169
                },
                new CountryOfResidenceEntity
                {
                    Id = 170,
                    Name = "Panama",
                    CountryIso2Code = "PA",
                    CountryIso3Code = "PAN",
                    IsAvailable = true,
                    Order = 170
                },
                new CountryOfResidenceEntity
                {
                    Id = 171,
                    Name = "Papua New Guinea",
                    CountryIso2Code = "PG",
                    CountryIso3Code = "PNG",
                    IsAvailable = true,
                    Order = 171
                },
                new CountryOfResidenceEntity
                {
                    Id = 172,
                    Name = "Paraguay",
                    CountryIso2Code = "PY",
                    CountryIso3Code = "PRY",
                    IsAvailable = true,
                    Order = 172
                },
                new CountryOfResidenceEntity
                {
                    Id = 173,
                    Name = "Peru",
                    CountryIso2Code = "PE",
                    CountryIso3Code = "PER",
                    IsAvailable = true,
                    Order = 173
                },
                new CountryOfResidenceEntity
                {
                    Id = 174,
                    Name = "Philippines",
                    CountryIso2Code = "PH",
                    CountryIso3Code = "PHL",
                    IsAvailable = true,
                    Order = 174
                },
                new CountryOfResidenceEntity
                {
                    Id = 175,
                    Name = "Pitcairn",
                    CountryIso2Code = "NZ",
                    CountryIso3Code = "NZL",
                    IsAvailable = true,
                    Order = 175
                },
                new CountryOfResidenceEntity
                {
                    Id = 176,
                    Name = "Poland",
                    CountryIso2Code = "PL",
                    CountryIso3Code = "POL",
                    IsAvailable = true,
                    Order = 176
                },
                new CountryOfResidenceEntity
                {
                    Id = 177,
                    Name = "Portugal",
                    CountryIso2Code = "PT",
                    CountryIso3Code = "PRT",
                    IsAvailable = true,
                    Order = 177
                },
                new CountryOfResidenceEntity
                {
                    Id = 178,
                    Name = "Qatar",
                    CountryIso2Code = "QA",
                    CountryIso3Code = "QAT",
                    IsAvailable = true,
                    Order = 178
                },
                new CountryOfResidenceEntity
                {
                    Id = 179,
                    Name = "Reunion",
                    CountryIso2Code = "RE",
                    CountryIso3Code = "REU",
                    IsAvailable = true,
                    Order = 179
                },
                new CountryOfResidenceEntity
                {
                    Id = 180,
                    Name = "Romania",
                    CountryIso2Code = "RO",
                    CountryIso3Code = "ROU",
                    IsAvailable = true,
                    Order = 180
                },
                new CountryOfResidenceEntity
                {
                    Id = 181,
                    Name = "Russian Federation",
                    CountryIso2Code = "RU",
                    CountryIso3Code = "RUS",
                    IsAvailable = true,
                    Order = 181
                },
                new CountryOfResidenceEntity
                {
                    Id = 182,
                    Name = "Rwanda",
                    CountryIso2Code = "RW",
                    CountryIso3Code = "RWA",
                    IsAvailable = true,
                    Order = 182
                },
                new CountryOfResidenceEntity
                {
                    Id = 183,
                    Name = "Saint Barthélemy",
                    CountryIso2Code = "BL",
                    CountryIso3Code = "BLM",
                    IsAvailable = true,
                    Order = 183
                },
                new CountryOfResidenceEntity
                {
                    Id = 184,
                    Name = "Saint Helena, Ascension and Tristan da Cunha",
                    CountryIso2Code = "SH",
                    CountryIso3Code = "SHN",
                    IsAvailable = true,
                    Order = 184
                },
                new CountryOfResidenceEntity
                {
                    Id = 185,
                    Name = "Saint Kitts and Nevis",
                    CountryIso2Code = "KN",
                    CountryIso3Code = "KNA",
                    IsAvailable = true,
                    Order = 185
                },
                new CountryOfResidenceEntity
                {
                    Id = 186,
                    Name = "Saint Lucia",
                    CountryIso2Code = "LC",
                    CountryIso3Code = "LCA",
                    IsAvailable = true,
                    Order = 186
                },
                new CountryOfResidenceEntity
                {
                    Id = 187,
                    Name = "Saint Martin (French part)",
                    CountryIso2Code = "MF",
                    CountryIso3Code = "MAF",
                    IsAvailable = true,
                    Order = 187
                },
                new CountryOfResidenceEntity
                {
                    Id = 188,
                    Name = "Saint Pierre and Miquelon",
                    CountryIso2Code = "PM",
                    CountryIso3Code = "SPM",
                    IsAvailable = true,
                    Order = 188
                },
                new CountryOfResidenceEntity
                {
                    Id = 189,
                    Name = "Saint Vincent and the Grenadines",
                    CountryIso2Code = "VC",
                    CountryIso3Code = "VCT",
                    IsAvailable = true,
                    Order = 189
                },
                new CountryOfResidenceEntity
                {
                    Id = 190,
                    Name = "Samoa",
                    CountryIso2Code = "WS",
                    CountryIso3Code = "WSM",
                    IsAvailable = true,
                    Order = 190
                },
                new CountryOfResidenceEntity
                {
                    Id = 191,
                    Name = "San Marino",
                    CountryIso2Code = "SM",
                    CountryIso3Code = "SMR",
                    IsAvailable = true,
                    Order = 191
                },
                new CountryOfResidenceEntity
                {
                    Id = 192,
                    Name = "Sao Tome and Principe",
                    CountryIso2Code = "ST",
                    CountryIso3Code = "STP",
                    IsAvailable = true,
                    Order = 192
                },
                new CountryOfResidenceEntity
                {
                    Id = 193,
                    Name = "Senegal",
                    CountryIso2Code = "SN",
                    CountryIso3Code = "SEN",
                    IsAvailable = true,
                    Order = 193
                },
                new CountryOfResidenceEntity
                {
                    Id = 194,
                    Name = "Serbia",
                    CountryIso2Code = "RS",
                    CountryIso3Code = "SRB",
                    IsAvailable = true,
                    Order = 194
                },
                new CountryOfResidenceEntity
                {
                    Id = 195,
                    Name = "Seychelles",
                    CountryIso2Code = "SC",
                    CountryIso3Code = "SYC",
                    IsAvailable = true,
                    Order = 195
                },
                new CountryOfResidenceEntity
                {
                    Id = 196,
                    Name = "Sierra Leone",
                    CountryIso2Code = "SL",
                    CountryIso3Code = "SLE",
                    IsAvailable = true,
                    Order = 196
                },
                new CountryOfResidenceEntity
                {
                    Id = 197,
                    Name = "Singapore",
                    CountryIso2Code = "SG",
                    CountryIso3Code = "SGP",
                    IsAvailable = true,
                    Order = 197
                },
                new CountryOfResidenceEntity
                {
                    Id = 198,
                    Name = "Sint Maarten (Dutch part)",
                    CountryIso2Code = "SX",
                    CountryIso3Code = "SXM",
                    IsAvailable = true,
                    Order = 198
                },
                new CountryOfResidenceEntity
                {
                    Id = 199,
                    Name = "Slovakia",
                    CountryIso2Code = "SK",
                    CountryIso3Code = "SVK",
                    IsAvailable = true,
                    Order = 199
                },
                new CountryOfResidenceEntity
                {
                    Id = 200,
                    Name = "Slovenia",
                    CountryIso2Code = "SI",
                    CountryIso3Code = "SVN",
                    IsAvailable = true,
                    Order = 200
                },
                new CountryOfResidenceEntity
                {
                    Id = 201,
                    Name = "Solomon Islands",
                    CountryIso2Code = "SB",
                    CountryIso3Code = "SLB",
                    IsAvailable = true,
                    Order = 201
                },
                new CountryOfResidenceEntity
                {
                    Id = 202,
                    Name = "Somalia",
                    CountryIso2Code = "SO",
                    CountryIso3Code = "SOM",
                    IsAvailable = true,
                    Order = 202
                },
                new CountryOfResidenceEntity
                {
                    Id = 203,
                    Name = "South Africa",
                    CountryIso2Code = "ZA",
                    CountryIso3Code = "ZAF",
                    IsAvailable = true,
                    Order = 203
                },
                new CountryOfResidenceEntity
                {
                    Id = 204,
                    Name = "South Georgia and the South Sandwich Islands",
                    CountryIso2Code = "GS",
                    CountryIso3Code = "SGS",
                    IsAvailable = true,
                    Order = 204
                },
                new CountryOfResidenceEntity
                {
                    Id = 205,
                    Name = "South Sudan",
                    CountryIso2Code = "SS",
                    CountryIso3Code = "SSD",
                    IsAvailable = true,
                    Order = 205
                },
                new CountryOfResidenceEntity
                {
                    Id = 206,
                    Name = "Spain",
                    CountryIso2Code = "ES",
                    CountryIso3Code = "ESP",
                    IsAvailable = true,
                    Order = 206
                },
                new CountryOfResidenceEntity
                {
                    Id = 207,
                    Name = "Sri Lanka",
                    CountryIso2Code = "LK",
                    CountryIso3Code = "LKA",
                    IsAvailable = true,
                    Order = 207
                },
                new CountryOfResidenceEntity
                {
                    Id = 208,
                    Name = "Suriname",
                    CountryIso2Code = "SR",
                    CountryIso3Code = "SUR",
                    IsAvailable = true,
                    Order = 208
                },
                new CountryOfResidenceEntity
                {
                    Id = 209,
                    Name = "Svalbard and Jan Mayen",
                    CountryIso2Code = "NO",
                    CountryIso3Code = "NOR",
                    IsAvailable = true,
                    Order = 209
                },
                new CountryOfResidenceEntity
                {
                    Id = 210,
                    Name = "Swaziland",
                    CountryIso2Code = "SZ",
                    CountryIso3Code = "SWZ",
                    IsAvailable = true,
                    Order = 210
                },
                new CountryOfResidenceEntity
                {
                    Id = 211,
                    Name = "Sweden",
                    CountryIso2Code = "SE",
                    CountryIso3Code = "SWE",
                    IsAvailable = true,
                    Order = 211
                },
                new CountryOfResidenceEntity
                {
                    Id = 212,
                    Name = "Switzerland",
                    CountryIso2Code = "CH",
                    CountryIso3Code = "CHE",
                    IsAvailable = true,
                    Order = 212
                },
                new CountryOfResidenceEntity
                {
                    Id = 213,
                    Name = "Taiwan",
                    CountryIso2Code = "TW",
                    CountryIso3Code = "TWN",
                    IsAvailable = true,
                    Order = 213
                },
                new CountryOfResidenceEntity
                {
                    Id = 214,
                    Name = "Tajikistan",
                    CountryIso2Code = "TJ",
                    CountryIso3Code = "TJK",
                    IsAvailable = true,
                    Order = 214
                },
                new CountryOfResidenceEntity
                {
                    Id = 215,
                    Name = "Tanzania, United Republic of",
                    CountryIso2Code = "TZ",
                    CountryIso3Code = "TZA",
                    IsAvailable = true,
                    Order = 215
                },
                new CountryOfResidenceEntity
                {
                    Id = 216,
                    Name = "Thailand",
                    CountryIso2Code = "TH",
                    CountryIso3Code = "THA",
                    IsAvailable = true,
                    Order = 216
                },
                new CountryOfResidenceEntity
                {
                    Id = 217,
                    Name = "Timor-Leste",
                    CountryIso2Code = "TL",
                    CountryIso3Code = "TLS",
                    IsAvailable = true,
                    Order = 217
                },
                new CountryOfResidenceEntity
                {
                    Id = 218,
                    Name = "Togo",
                    CountryIso2Code = "TG",
                    CountryIso3Code = "TGO",
                    IsAvailable = true,
                    Order = 218
                },
                new CountryOfResidenceEntity
                {
                    Id = 219,
                    Name = "Tokelau",
                    CountryIso2Code = "TK",
                    CountryIso3Code = "TKL",
                    IsAvailable = true,
                    Order = 219
                },
                new CountryOfResidenceEntity
                {
                    Id = 220,
                    Name = "Tonga",
                    CountryIso2Code = "TO",
                    CountryIso3Code = "TON",
                    IsAvailable = true,
                    Order = 220
                },
                new CountryOfResidenceEntity
                {
                    Id = 221,
                    Name = "Trinidad and Tobago",
                    CountryIso2Code = "TT",
                    CountryIso3Code = "TTO",
                    IsAvailable = true,
                    Order = 221
                },
                new CountryOfResidenceEntity
                {
                    Id = 222,
                    Name = "Tunisia",
                    CountryIso2Code = "TN",
                    CountryIso3Code = "TUN",
                    IsAvailable = true,
                    Order = 222
                },
                new CountryOfResidenceEntity
                {
                    Id = 223,
                    Name = "Turkey",
                    CountryIso2Code = "TR",
                    CountryIso3Code = "TUR",
                    IsAvailable = true,
                    Order = 223
                },
                new CountryOfResidenceEntity
                {
                    Id = 224,
                    Name = "Turkmenistan",
                    CountryIso2Code = "TM",
                    CountryIso3Code = "TKM",
                    IsAvailable = true,
                    Order = 224
                },
                new CountryOfResidenceEntity
                {
                    Id = 225,
                    Name = "Turks and Caicos Islands",
                    CountryIso2Code = "TC",
                    CountryIso3Code = "TCA",
                    IsAvailable = true,
                    Order = 225
                },
                new CountryOfResidenceEntity
                {
                    Id = 226,
                    Name = "Tuvalu",
                    CountryIso2Code = "TV",
                    CountryIso3Code = "TUV",
                    IsAvailable = true,
                    Order = 226
                },
                new CountryOfResidenceEntity
                {
                    Id = 227,
                    Name = "Uganda",
                    CountryIso2Code = "UG",
                    CountryIso3Code = "UGA",
                    IsAvailable = true,
                    Order = 227
                },
                new CountryOfResidenceEntity
                {
                    Id = 228,
                    Name = "Ukraine",
                    CountryIso2Code = "UA",
                    CountryIso3Code = "UKR",
                    IsAvailable = true,
                    Order = 228
                },
                new CountryOfResidenceEntity
                {
                    Id = 229,
                    Name = "Uruguay",
                    CountryIso2Code = "UY",
                    CountryIso3Code = "URY",
                    IsAvailable = true,
                    Order = 229
                },
                new CountryOfResidenceEntity
                {
                    Id = 230,
                    Name = "Uzbekistan",
                    CountryIso2Code = "UZ",
                    CountryIso3Code = "UZB",
                    IsAvailable = true,
                    Order = 230
                },
                new CountryOfResidenceEntity
                {
                    Id = 231,
                    Name = "Vanuatu",
                    CountryIso2Code = "VU",
                    CountryIso3Code = "VUT",
                    IsAvailable = true,
                    Order = 231
                },
                new CountryOfResidenceEntity
                {
                    Id = 232,
                    Name = "Venezuela, Bolivarian Republic of",
                    CountryIso2Code = "VE",
                    CountryIso3Code = "VEN",
                    IsAvailable = true,
                    Order = 232
                },
                new CountryOfResidenceEntity
                {
                    Id = 233,
                    Name = "Vietnam",
                    CountryIso2Code = "VN",
                    CountryIso3Code = "VNM",
                    IsAvailable = true,
                    Order = 233
                },
                new CountryOfResidenceEntity
                {
                    Id = 234,
                    Name = "Virgin Islands, British",
                    CountryIso2Code = "VG",
                    CountryIso3Code = "VGB",
                    IsAvailable = true,
                    Order = 234
                },
                new CountryOfResidenceEntity
                {
                    Id = 235,
                    Name = "Wallis and Futuna",
                    CountryIso2Code = "WF",
                    CountryIso3Code = "WLF",
                    IsAvailable = true,
                    Order = 235
                },
                new CountryOfResidenceEntity
                {
                    Id = 236,
                    Name = "Western Sahara",
                    CountryIso2Code = "MA",
                    CountryIso3Code = "MAR",
                    IsAvailable = true,
                    Order = 236
                },
                new CountryOfResidenceEntity
                {
                    Id = 237,
                    Name = "Yemen",
                    CountryIso2Code = "YE",
                    CountryIso3Code = "YEM",
                    IsAvailable = true,
                    Order = 237
                },
                new CountryOfResidenceEntity
                {
                    Id = 238,
                    Name = "Zambia",
                    CountryIso2Code = "ZM",
                    CountryIso3Code = "ZMB",
                    IsAvailable = true,
                    Order = 238
                },
                new CountryOfResidenceEntity
                {
                    Id = 239,
                    Name = "Zimbabwe",
                    CountryIso2Code = "ZW",
                    CountryIso3Code = "ZWE",
                    IsAvailable = true,
                    Order = 239
                },
                new CountryOfResidenceEntity
                {
                    Id = 240,
                    Name = "Hong Kong",
                    CountryIso2Code = "HK",
                    CountryIso3Code = "HKG",
                    IsAvailable = true,
                    Order = 240
                },
                new CountryOfResidenceEntity
                {
                    Id = 241,
                    Name = "Republic of Kosovo",
                    CountryIso2Code = "XK",
                    CountryIso3Code = "XKX",
                    IsAvailable = true,
                    Order = 241
                }
            };

        internal static IReadOnlyList<CountryPhoneCodeEntity> GetCountryPhoneCodes()
            => new[]
            {
                new CountryPhoneCodeEntity
                {
                    Id = 1,
                    Code = "0091",
                    IsoCode = "+91",
                    CountryName = "India",
                    CountryIso2Code = "IN",
                    CountryIso3Code = "IND",
                    IsAvailable = true,
                    Order = 1
                },
                new CountryPhoneCodeEntity
                {
                    Id = 2,
                    Code = "00966",
                    IsoCode = "+966",
                    CountryName = "Saudi Arabia",
                    CountryIso2Code = "SA",
                    CountryIso3Code = "SAU",
                    IsAvailable = true,
                    Order = 2
                },
                new CountryPhoneCodeEntity
                {
                    Id = 3,
                    Code = "0092",
                    IsoCode = "+92",
                    CountryName = "Pakistan",
                    CountryIso2Code = "PK",
                    CountryIso3Code = "PAK",
                    IsAvailable = true,
                    Order = 3
                },
                new CountryPhoneCodeEntity
                {
                    Id = 4,
                    Code = "00962",
                    IsoCode = "+962",
                    CountryName = "Jordan",
                    CountryIso2Code = "JO",
                    CountryIso3Code = "JOR",
                    IsAvailable = true,
                    Order = 4
                },
                new CountryPhoneCodeEntity
                {
                    Id = 5,
                    Code = "0044",
                    IsoCode = "+44",
                    CountryName = "United Kingdom",
                    CountryIso2Code = "GB",
                    CountryIso3Code = "GBR",
                    IsAvailable = true,
                    Order = 5
                },
                new CountryPhoneCodeEntity
                {
                    Id = 6,
                    Code = "0020",
                    IsoCode = "+20",
                    CountryName = "Egypt",
                    CountryIso2Code = "EG",
                    CountryIso3Code = "EGY",
                    IsAvailable = true,
                    Order = 6
                },
                new CountryPhoneCodeEntity
                {
                    Id = 7,
                    Code = "00963",
                    IsoCode = "+963",
                    CountryName = "Syria",
                    CountryIso2Code = "SY",
                    CountryIso3Code = "SYR",
                    IsAvailable = true,
                    Order = 7
                },
                new CountryPhoneCodeEntity
                {
                    Id = 8,
                    Code = "001",
                    IsoCode = "+1",
                    CountryName = "Canada",
                    CountryIso2Code = "CA",
                    CountryIso3Code = "CAN",
                    IsAvailable = true,
                    Order = 8
                },
                new CountryPhoneCodeEntity
                {
                    Id = 9,
                    Code = "00961",
                    IsoCode = "+961",
                    CountryName = "Lebanon",
                    CountryIso2Code = "LB",
                    CountryIso3Code = "LBN",
                    IsAvailable = true,
                    Order = 9
                },
                new CountryPhoneCodeEntity
                {
                    Id = 10,
                    Code = "00249",
                    IsoCode = "+249",
                    CountryName = "Sudan",
                    CountryIso2Code = "SD",
                    CountryIso3Code = "SDN",
                    IsAvailable = true,
                    Order = 10
                },
                new CountryPhoneCodeEntity
                {
                    Id = 11,
                    Code = "001",
                    IsoCode = "+1",
                    CountryName = "United States",
                    CountryIso2Code = "US",
                    CountryIso3Code = "USA",
                    IsAvailable = true,
                    Order = 11
                },
                new CountryPhoneCodeEntity
                {
                    Id = 12,
                    Code = "00965",
                    IsoCode = "+965",
                    CountryName = "Kuwait",
                    CountryIso2Code = "KW",
                    CountryIso3Code = "KWT",
                    IsAvailable = true,
                    Order = 12
                },
                new CountryPhoneCodeEntity
                {
                    Id = 13,
                    Code = "0098",
                    IsoCode = "+98",
                    CountryName = "Iran",
                    CountryIso2Code = "IR",
                    CountryIso3Code = "IRN",
                    IsAvailable = true,
                    Order = 13
                },
                new CountryPhoneCodeEntity
                {
                    Id = 14,
                    Code = "00964",
                    IsoCode = "+964",
                    CountryName = "Iraq",
                    CountryIso2Code = "IQ",
                    CountryIso3Code = "IRQ",
                    IsAvailable = true,
                    Order = 14
                },
                new CountryPhoneCodeEntity
                {
                    Id = 15,
                    Code = "0093",
                    IsoCode = "+93",
                    CountryName = "Afghanistan",
                    CountryIso2Code = "AF",
                    CountryIso3Code = "AFG",
                    IsAvailable = true,
                    Order = 15
                },
                new CountryPhoneCodeEntity
                {
                    Id = 16,
                    Code = "00355",
                    IsoCode = "+355",
                    CountryName = "Albania",
                    CountryIso2Code = "AL",
                    CountryIso3Code = "ALB",
                    IsAvailable = true,
                    Order = 16
                },
                new CountryPhoneCodeEntity
                {
                    Id = 17,
                    Code = "00213",
                    IsoCode = "+213",
                    CountryName = "Algeria",
                    CountryIso2Code = "DZ",
                    CountryIso3Code = "DZA",
                    IsAvailable = true,
                    Order = 17
                },
                new CountryPhoneCodeEntity
                {
                    Id = 18,
                    Code = "001-684",
                    IsoCode = "+1-684",
                    CountryName = "American Samoa",
                    CountryIso2Code = "AS",
                    CountryIso3Code = "ASM",
                    IsAvailable = true,
                    Order = 18
                },
                new CountryPhoneCodeEntity
                {
                    Id = 19,
                    Code = "00376",
                    IsoCode = "+376",
                    CountryName = "Andorra",
                    CountryIso2Code = "AD",
                    CountryIso3Code = "AND",
                    IsAvailable = true,
                    Order = 19
                },
                new CountryPhoneCodeEntity
                {
                    Id = 20,
                    Code = "00244",
                    IsoCode = "+244",
                    CountryName = "Angola",
                    CountryIso2Code = "AO",
                    CountryIso3Code = "AGO",
                    IsAvailable = true,
                    Order = 20
                },
                new CountryPhoneCodeEntity
                {
                    Id = 21,
                    Code = "001-264",
                    IsoCode = "+1-264",
                    CountryName = "Anguilla",
                    CountryIso2Code = "AI",
                    CountryIso3Code = "AIA",
                    IsAvailable = true,
                    Order = 21
                },
                new CountryPhoneCodeEntity
                {
                    Id = 22,
                    Code = "00672",
                    IsoCode = "+672",
                    CountryName = "Antarctica",
                    CountryIso2Code = "AQ",
                    CountryIso3Code = "ATA",
                    IsAvailable = true,
                    Order = 22
                },
                new CountryPhoneCodeEntity
                {
                    Id = 23,
                    Code = "001-268",
                    IsoCode = "+1-268",
                    CountryName = "Antigua and Barbuda",
                    CountryIso2Code = "AG",
                    CountryIso3Code = "ATG",
                    IsAvailable = true,
                    Order = 23
                },
                new CountryPhoneCodeEntity
                {
                    Id = 24,
                    Code = "0054",
                    IsoCode = "+54",
                    CountryName = "Argentina",
                    CountryIso2Code = "AR",
                    CountryIso3Code = "ARG",
                    IsAvailable = true,
                    Order = 24
                },
                new CountryPhoneCodeEntity
                {
                    Id = 25,
                    Code = "00374",
                    IsoCode = "+374",
                    CountryName = "Armenia",
                    CountryIso2Code = "AM",
                    CountryIso3Code = "ARM",
                    IsAvailable = true,
                    Order = 25
                },
                new CountryPhoneCodeEntity
                {
                    Id = 26,
                    Code = "00297",
                    IsoCode = "+297",
                    CountryName = "Aruba",
                    CountryIso2Code = "AW",
                    CountryIso3Code = "ABW",
                    IsAvailable = true,
                    Order = 26
                },
                new CountryPhoneCodeEntity
                {
                    Id = 27,
                    Code = "0061",
                    IsoCode = "+61",
                    CountryName = "Australia",
                    CountryIso2Code = "AU",
                    CountryIso3Code = "AUS",
                    IsAvailable = true,
                    Order = 27
                },
                new CountryPhoneCodeEntity
                {
                    Id = 28,
                    Code = "0043",
                    IsoCode = "+43",
                    CountryName = "Austria",
                    CountryIso2Code = "AT",
                    CountryIso3Code = "AUT",
                    IsAvailable = true,
                    Order = 28
                },
                new CountryPhoneCodeEntity
                {
                    Id = 29,
                    Code = "00994",
                    IsoCode = "+994",
                    CountryName = "Azerbaijan",
                    CountryIso2Code = "AZ",
                    CountryIso3Code = "AZE",
                    IsAvailable = true,
                    Order = 29
                },
                new CountryPhoneCodeEntity
                {
                    Id = 30,
                    Code = "001-242",
                    IsoCode = "+1-242",
                    CountryName = "Bahamas",
                    CountryIso2Code = "BS",
                    CountryIso3Code = "BHS",
                    IsAvailable = true,
                    Order = 30
                },
                new CountryPhoneCodeEntity
                {
                    Id = 31,
                    Code = "00973",
                    IsoCode = "+973",
                    CountryName = "Bahrain",
                    CountryIso2Code = "BH",
                    CountryIso3Code = "BHR",
                    IsAvailable = true,
                    Order = 31
                },
                new CountryPhoneCodeEntity
                {
                    Id = 32,
                    Code = "00880",
                    IsoCode = "+880",
                    CountryName = "Bangladesh",
                    CountryIso2Code = "BD",
                    CountryIso3Code = "BGD",
                    IsAvailable = true,
                    Order = 32
                },
                new CountryPhoneCodeEntity
                {
                    Id = 33,
                    Code = "001-246",
                    IsoCode = "+1-246",
                    CountryName = "Barbados",
                    CountryIso2Code = "BB",
                    CountryIso3Code = "BRB",
                    IsAvailable = true,
                    Order = 33
                },
                new CountryPhoneCodeEntity
                {
                    Id = 34,
                    Code = "00375",
                    IsoCode = "+375",
                    CountryName = "Belarus",
                    CountryIso2Code = "BY",
                    CountryIso3Code = "BLR",
                    IsAvailable = true,
                    Order = 34
                },
                new CountryPhoneCodeEntity
                {
                    Id = 35,
                    Code = "0032",
                    IsoCode = "+32",
                    CountryName = "Belgium",
                    CountryIso2Code = "BE",
                    CountryIso3Code = "BEL",
                    IsAvailable = true,
                    Order = 35
                },
                new CountryPhoneCodeEntity
                {
                    Id = 36,
                    Code = "00501",
                    IsoCode = "+501",
                    CountryName = "Belize",
                    CountryIso2Code = "BZ",
                    CountryIso3Code = "BLZ",
                    IsAvailable = true,
                    Order = 36
                },
                new CountryPhoneCodeEntity
                {
                    Id = 37,
                    Code = "00229",
                    IsoCode = "+229",
                    CountryName = "Benin",
                    CountryIso2Code = "BJ",
                    CountryIso3Code = "BEN",
                    IsAvailable = true,
                    Order = 37
                },
                new CountryPhoneCodeEntity
                {
                    Id = 38,
                    Code = "001-441",
                    IsoCode = "+1-441",
                    CountryName = "Bermuda",
                    CountryIso2Code = "BM",
                    CountryIso3Code = "BMU",
                    IsAvailable = true,
                    Order = 38
                },
                new CountryPhoneCodeEntity
                {
                    Id = 39,
                    Code = "00975",
                    IsoCode = "+975",
                    CountryName = "Bhutan",
                    CountryIso2Code = "BT",
                    CountryIso3Code = "BTN",
                    IsAvailable = true,
                    Order = 39
                },
                new CountryPhoneCodeEntity
                {
                    Id = 40,
                    Code = "00591",
                    IsoCode = "+591",
                    CountryName = "Bolivia",
                    CountryIso2Code = "BO",
                    CountryIso3Code = "BOL",
                    IsAvailable = true,
                    Order = 40
                },
                new CountryPhoneCodeEntity
                {
                    Id = 41,
                    Code = "00387",
                    IsoCode = "+387",
                    CountryName = "Bosnia and Herzegovina",
                    CountryIso2Code = "BA",
                    CountryIso3Code = "BIH",
                    IsAvailable = true,
                    Order = 41
                },
                new CountryPhoneCodeEntity
                {
                    Id = 42,
                    Code = "00267",
                    IsoCode = "+267",
                    CountryName = "Botswana",
                    CountryIso2Code = "BW",
                    CountryIso3Code = "BWA",
                    IsAvailable = true,
                    Order = 42
                },
                new CountryPhoneCodeEntity
                {
                    Id = 43,
                    Code = "0055",
                    IsoCode = "+55",
                    CountryName = "Brazil",
                    CountryIso2Code = "BR",
                    CountryIso3Code = "BRA",
                    IsAvailable = true,
                    Order = 43
                },
                new CountryPhoneCodeEntity
                {
                    Id = 44,
                    Code = "00246",
                    IsoCode = "+246",
                    CountryName = "British Indian Ocean Territory",
                    CountryIso2Code = "IO",
                    CountryIso3Code = "IOT",
                    IsAvailable = true,
                    Order = 44
                },
                new CountryPhoneCodeEntity
                {
                    Id = 45,
                    Code = "001-284",
                    IsoCode = "+1-284",
                    CountryName = "British Virgin Islands",
                    CountryIso2Code = "VG",
                    CountryIso3Code = "VGB",
                    IsAvailable = true,
                    Order = 45
                },
                new CountryPhoneCodeEntity
                {
                    Id = 46,
                    Code = "00673",
                    IsoCode = "+673",
                    CountryName = "Brunei",
                    CountryIso2Code = "BN",
                    CountryIso3Code = "BRN",
                    IsAvailable = true,
                    Order = 46
                },
                new CountryPhoneCodeEntity
                {
                    Id = 47,
                    Code = "00359",
                    IsoCode = "+359",
                    CountryName = "Bulgaria",
                    CountryIso2Code = "BG",
                    CountryIso3Code = "BGR",
                    IsAvailable = true,
                    Order = 47
                },
                new CountryPhoneCodeEntity
                {
                    Id = 48,
                    Code = "00226",
                    IsoCode = "+226",
                    CountryName = "Burkina Faso",
                    CountryIso2Code = "BF",
                    CountryIso3Code = "BFA",
                    IsAvailable = true,
                    Order = 48
                },
                new CountryPhoneCodeEntity
                {
                    Id = 49,
                    Code = "00257",
                    IsoCode = "+257",
                    CountryName = "Burundi",
                    CountryIso2Code = "BI",
                    CountryIso3Code = "BDI",
                    IsAvailable = true,
                    Order = 49
                },
                new CountryPhoneCodeEntity
                {
                    Id = 50,
                    Code = "00855",
                    IsoCode = "+855",
                    CountryName = "Cambodia",
                    CountryIso2Code = "KH",
                    CountryIso3Code = "KHM",
                    IsAvailable = true,
                    Order = 50
                },
                new CountryPhoneCodeEntity
                {
                    Id = 51,
                    Code = "00237",
                    IsoCode = "+237",
                    CountryName = "Cameroon",
                    CountryIso2Code = "CM",
                    CountryIso3Code = "CMR",
                    IsAvailable = true,
                    Order = 51
                },
                new CountryPhoneCodeEntity
                {
                    Id = 52,
                    Code = "00238",
                    IsoCode = "+238",
                    CountryName = "Cape Verde",
                    CountryIso2Code = "CV",
                    CountryIso3Code = "CPV",
                    IsAvailable = true,
                    Order = 52
                },
                new CountryPhoneCodeEntity
                {
                    Id = 53,
                    Code = "001-345",
                    IsoCode = "+1-345",
                    CountryName = "Cayman Islands",
                    CountryIso2Code = "KY",
                    CountryIso3Code = "CYM",
                    IsAvailable = true,
                    Order = 53
                },
                new CountryPhoneCodeEntity
                {
                    Id = 54,
                    Code = "00236",
                    IsoCode = "+236",
                    CountryName = "Central African Republic",
                    CountryIso2Code = "CF",
                    CountryIso3Code = "CAF",
                    IsAvailable = true,
                    Order = 54
                },
                new CountryPhoneCodeEntity
                {
                    Id = 55,
                    Code = "00235",
                    IsoCode = "+235",
                    CountryName = "Chad",
                    CountryIso2Code = "TD",
                    CountryIso3Code = "TCD",
                    IsAvailable = true,
                    Order = 55
                },
                new CountryPhoneCodeEntity
                {
                    Id = 56,
                    Code = "0056",
                    IsoCode = "+56",
                    CountryName = "Chile",
                    CountryIso2Code = "CL",
                    CountryIso3Code = "CHL",
                    IsAvailable = true,
                    Order = 56
                },
                new CountryPhoneCodeEntity
                {
                    Id = 57,
                    Code = "0086",
                    IsoCode = "+86",
                    CountryName = "China",
                    CountryIso2Code = "CN",
                    CountryIso3Code = "CHN",
                    IsAvailable = true,
                    Order = 57
                },
                new CountryPhoneCodeEntity
                {
                    Id = 58,
                    Code = "0061",
                    IsoCode = "+61",
                    CountryName = "Christmas Island",
                    CountryIso2Code = "CX",
                    CountryIso3Code = "CXR",
                    IsAvailable = true,
                    Order = 58
                },
                new CountryPhoneCodeEntity
                {
                    Id = 59,
                    Code = "0061",
                    IsoCode = "+61",
                    CountryName = "Cocos Islands",
                    CountryIso2Code = "CC",
                    CountryIso3Code = "CCK",
                    IsAvailable = true,
                    Order = 59
                },
                new CountryPhoneCodeEntity
                {
                    Id = 60,
                    Code = "0057",
                    IsoCode = "+57",
                    CountryName = "Colombia",
                    CountryIso2Code = "CO",
                    CountryIso3Code = "COL",
                    IsAvailable = true,
                    Order = 60
                },
                new CountryPhoneCodeEntity
                {
                    Id = 61,
                    Code = "00269",
                    IsoCode = "+269",
                    CountryName = "Comoros",
                    CountryIso2Code = "KM",
                    CountryIso3Code = "COM",
                    IsAvailable = true,
                    Order = 61
                },
                new CountryPhoneCodeEntity
                {
                    Id = 62,
                    Code = "00682",
                    IsoCode = "+682",
                    CountryName = "Cook Islands",
                    CountryIso2Code = "CK",
                    CountryIso3Code = "COK",
                    IsAvailable = true,
                    Order = 62
                },
                new CountryPhoneCodeEntity
                {
                    Id = 63,
                    Code = "00506",
                    IsoCode = "+506",
                    CountryName = "Costa Rica",
                    CountryIso2Code = "CR",
                    CountryIso3Code = "CRI",
                    IsAvailable = true,
                    Order = 63
                },
                new CountryPhoneCodeEntity
                {
                    Id = 64,
                    Code = "00385",
                    IsoCode = "+385",
                    CountryName = "Croatia",
                    CountryIso2Code = "HR",
                    CountryIso3Code = "HRV",
                    IsAvailable = true,
                    Order = 64
                },
                new CountryPhoneCodeEntity
                {
                    Id = 65,
                    Code = "0053",
                    IsoCode = "+53",
                    CountryName = "Cuba",
                    CountryIso2Code = "CU",
                    CountryIso3Code = "CUB",
                    IsAvailable = true,
                    Order = 65
                },
                new CountryPhoneCodeEntity
                {
                    Id = 66,
                    Code = "00599",
                    IsoCode = "+599",
                    CountryName = "Curacao",
                    CountryIso2Code = "CW",
                    CountryIso3Code = "CUW",
                    IsAvailable = true,
                    Order = 66
                },
                new CountryPhoneCodeEntity
                {
                    Id = 67,
                    Code = "00357",
                    IsoCode = "+357",
                    CountryName = "Cyprus",
                    CountryIso2Code = "CY",
                    CountryIso3Code = "CYP",
                    IsAvailable = true,
                    Order = 67
                },
                new CountryPhoneCodeEntity
                {
                    Id = 68,
                    Code = "00420",
                    IsoCode = "+420",
                    CountryName = "Czech Republic",
                    CountryIso2Code = "CZ",
                    CountryIso3Code = "CZE",
                    IsAvailable = true,
                    Order = 68
                },
                new CountryPhoneCodeEntity
                {
                    Id = 69,
                    Code = "00243",
                    IsoCode = "+243",
                    CountryName = "Democratic Republic of the Congo",
                    CountryIso2Code = "CD",
                    CountryIso3Code = "COD",
                    IsAvailable = true,
                    Order = 69
                },
                new CountryPhoneCodeEntity
                {
                    Id = 70,
                    Code = "0045",
                    IsoCode = "+45",
                    CountryName = "Denmark",
                    CountryIso2Code = "DK",
                    CountryIso3Code = "DNK",
                    IsAvailable = true,
                    Order = 70
                },
                new CountryPhoneCodeEntity
                {
                    Id = 71,
                    Code = "00253",
                    IsoCode = "+253",
                    CountryName = "Djibouti",
                    CountryIso2Code = "DJ",
                    CountryIso3Code = "DJI",
                    IsAvailable = true,
                    Order = 71
                },
                new CountryPhoneCodeEntity
                {
                    Id = 72,
                    Code = "001-767",
                    IsoCode = "+1-767",
                    CountryName = "Dominica",
                    CountryIso2Code = "DM",
                    CountryIso3Code = "DMA",
                    IsAvailable = true,
                    Order = 72
                },
                new CountryPhoneCodeEntity
                {
                    Id = 73,
                    Code = "001-809",
                    IsoCode = "+1-809",
                    CountryName = "Dominican Republic",
                    CountryIso2Code = "DO",
                    CountryIso3Code = "DOM",
                    IsAvailable = true,
                    Order = 73
                },
                new CountryPhoneCodeEntity
                {
                    Id = 74,
                    Code = "001-829",
                    IsoCode = "+1-829",
                    CountryName = "Dominican Republic",
                    CountryIso2Code = "DO",
                    CountryIso3Code = "DOM",
                    IsAvailable = true,
                    Order = 74
                },
                new CountryPhoneCodeEntity
                {
                    Id = 75,
                    Code = "001-849",
                    IsoCode = "+1-849",
                    CountryName = "Dominican Republic",
                    CountryIso2Code = "DO",
                    CountryIso3Code = "DOM",
                    IsAvailable = true,
                    Order = 75
                },
                new CountryPhoneCodeEntity
                {
                    Id = 76,
                    Code = "00670",
                    IsoCode = "+670",
                    CountryName = "East Timor",
                    CountryIso2Code = "TL",
                    CountryIso3Code = "TLS",
                    IsAvailable = true,
                    Order = 76
                },
                new CountryPhoneCodeEntity
                {
                    Id = 77,
                    Code = "00593",
                    IsoCode = "+593",
                    CountryName = "Ecuador",
                    CountryIso2Code = "EC",
                    CountryIso3Code = "ECU",
                    IsAvailable = true,
                    Order = 77
                },
                new CountryPhoneCodeEntity
                {
                    Id = 78,
                    Code = "00503",
                    IsoCode = "+503",
                    CountryName = "El Salvador",
                    CountryIso2Code = "SV",
                    CountryIso3Code = "SLV",
                    IsAvailable = true,
                    Order = 78
                },
                new CountryPhoneCodeEntity
                {
                    Id = 79,
                    Code = "00240",
                    IsoCode = "+240",
                    CountryName = "Equatorial Guinea",
                    CountryIso2Code = "GQ",
                    CountryIso3Code = "GNQ",
                    IsAvailable = true,
                    Order = 79
                },
                new CountryPhoneCodeEntity
                {
                    Id = 80,
                    Code = "00291",
                    IsoCode = "+291",
                    CountryName = "Eritrea",
                    CountryIso2Code = "ER",
                    CountryIso3Code = "ERI",
                    IsAvailable = true,
                    Order = 80
                },
                new CountryPhoneCodeEntity
                {
                    Id = 81,
                    Code = "00372",
                    IsoCode = "+372",
                    CountryName = "Estonia",
                    CountryIso2Code = "EE",
                    CountryIso3Code = "EST",
                    IsAvailable = true,
                    Order = 81
                },
                new CountryPhoneCodeEntity
                {
                    Id = 82,
                    Code = "00251",
                    IsoCode = "+251",
                    CountryName = "Ethiopia",
                    CountryIso2Code = "ET",
                    CountryIso3Code = "ETH",
                    IsAvailable = true,
                    Order = 82
                },
                new CountryPhoneCodeEntity
                {
                    Id = 83,
                    Code = "00500",
                    IsoCode = "+500",
                    CountryName = "Falkland Islands",
                    CountryIso2Code = "FK",
                    CountryIso3Code = "FLK",
                    IsAvailable = true,
                    Order = 83
                },
                new CountryPhoneCodeEntity
                {
                    Id = 84,
                    Code = "00298",
                    IsoCode = "+298",
                    CountryName = "Faroe Islands",
                    CountryIso2Code = "FO",
                    CountryIso3Code = "FRO",
                    IsAvailable = true,
                    Order = 84
                },
                new CountryPhoneCodeEntity
                {
                    Id = 85,
                    Code = "00679",
                    IsoCode = "+679",
                    CountryName = "Fiji",
                    CountryIso2Code = "FJ",
                    CountryIso3Code = "FJI",
                    IsAvailable = true,
                    Order = 85
                },
                new CountryPhoneCodeEntity
                {
                    Id = 86,
                    Code = "00358",
                    IsoCode = "+358",
                    CountryName = "Finland",
                    CountryIso2Code = "FI",
                    CountryIso3Code = "FIN",
                    IsAvailable = true,
                    Order = 86
                },
                new CountryPhoneCodeEntity
                {
                    Id = 87,
                    Code = "0033",
                    IsoCode = "+33",
                    CountryName = "France",
                    CountryIso2Code = "FR",
                    CountryIso3Code = "FRA",
                    IsAvailable = true,
                    Order = 87
                },
                new CountryPhoneCodeEntity
                {
                    Id = 88,
                    Code = "00689",
                    IsoCode = "+689",
                    CountryName = "French Polynesia",
                    CountryIso2Code = "PF",
                    CountryIso3Code = "PYF",
                    IsAvailable = true,
                    Order = 88
                },
                new CountryPhoneCodeEntity
                {
                    Id = 89,
                    Code = "00241",
                    IsoCode = "+241",
                    CountryName = "Gabon",
                    CountryIso2Code = "GA",
                    CountryIso3Code = "GAB",
                    IsAvailable = true,
                    Order = 89
                },
                new CountryPhoneCodeEntity
                {
                    Id = 90,
                    Code = "00220",
                    IsoCode = "+220",
                    CountryName = "Gambia",
                    CountryIso2Code = "GM",
                    CountryIso3Code = "GMB",
                    IsAvailable = true,
                    Order = 90
                },
                new CountryPhoneCodeEntity
                {
                    Id = 91,
                    Code = "00995",
                    IsoCode = "+995",
                    CountryName = "Georgia",
                    CountryIso2Code = "GE",
                    CountryIso3Code = "GEO",
                    IsAvailable = true,
                    Order = 91
                },
                new CountryPhoneCodeEntity
                {
                    Id = 92,
                    Code = "0049",
                    IsoCode = "+49",
                    CountryName = "Germany",
                    CountryIso2Code = "DE",
                    CountryIso3Code = "DEU",
                    IsAvailable = true,
                    Order = 92
                },
                new CountryPhoneCodeEntity
                {
                    Id = 93,
                    Code = "00233",
                    IsoCode = "+233",
                    CountryName = "Ghana",
                    CountryIso2Code = "GH",
                    CountryIso3Code = "GHA",
                    IsAvailable = true,
                    Order = 93
                },
                new CountryPhoneCodeEntity
                {
                    Id = 94,
                    Code = "00350",
                    IsoCode = "+350",
                    CountryName = "Gibraltar",
                    CountryIso2Code = "GI",
                    CountryIso3Code = "GIB",
                    IsAvailable = true,
                    Order = 94
                },
                new CountryPhoneCodeEntity
                {
                    Id = 95,
                    Code = "0030",
                    IsoCode = "+30",
                    CountryName = "Greece",
                    CountryIso2Code = "GR",
                    CountryIso3Code = "GRC",
                    IsAvailable = true,
                    Order = 95
                },
                new CountryPhoneCodeEntity
                {
                    Id = 96,
                    Code = "00299",
                    IsoCode = "+299",
                    CountryName = "Greenland",
                    CountryIso2Code = "GL",
                    CountryIso3Code = "GRL",
                    IsAvailable = true,
                    Order = 96
                },
                new CountryPhoneCodeEntity
                {
                    Id = 97,
                    Code = "001-473",
                    IsoCode = "+1-473",
                    CountryName = "Grenada",
                    CountryIso2Code = "GD",
                    CountryIso3Code = "GRD",
                    IsAvailable = true,
                    Order = 97
                },
                new CountryPhoneCodeEntity
                {
                    Id = 98,
                    Code = "001-671",
                    IsoCode = "+1-671",
                    CountryName = "Guam",
                    CountryIso2Code = "GU",
                    CountryIso3Code = "GUM",
                    IsAvailable = true,
                    Order = 98
                },
                new CountryPhoneCodeEntity
                {
                    Id = 99,
                    Code = "00502",
                    IsoCode = "+502",
                    CountryName = "Guatemala",
                    CountryIso2Code = "GT",
                    CountryIso3Code = "GTM",
                    IsAvailable = true,
                    Order = 99
                },
                new CountryPhoneCodeEntity
                {
                    Id = 100,
                    Code = "0044-1481",
                    IsoCode = "+44-1481",
                    CountryName = "Guernsey",
                    CountryIso2Code = "GG",
                    CountryIso3Code = "GGY",
                    IsAvailable = true,
                    Order = 100
                },
                new CountryPhoneCodeEntity
                {
                    Id = 101,
                    Code = "00224",
                    IsoCode = "+224",
                    CountryName = "Guinea",
                    CountryIso2Code = "GN",
                    CountryIso3Code = "GIN",
                    IsAvailable = true,
                    Order = 101
                },
                new CountryPhoneCodeEntity
                {
                    Id = 102,
                    Code = "00245",
                    IsoCode = "+245",
                    CountryName = "Guinea-Bissau",
                    CountryIso2Code = "GW",
                    CountryIso3Code = "GNB",
                    IsAvailable = true,
                    Order = 102
                },
                new CountryPhoneCodeEntity
                {
                    Id = 103,
                    Code = "00592",
                    IsoCode = "+592",
                    CountryName = "Guyana",
                    CountryIso2Code = "GY",
                    CountryIso3Code = "GUY",
                    IsAvailable = true,
                    Order = 103
                },
                new CountryPhoneCodeEntity
                {
                    Id = 104,
                    Code = "00509",
                    IsoCode = "+509",
                    CountryName = "Haiti",
                    CountryIso2Code = "HT",
                    CountryIso3Code = "HTI",
                    IsAvailable = true,
                    Order = 104
                },
                new CountryPhoneCodeEntity
                {
                    Id = 105,
                    Code = "00504",
                    IsoCode = "+504",
                    CountryName = "Honduras",
                    CountryIso2Code = "HN",
                    CountryIso3Code = "HND",
                    IsAvailable = true,
                    Order = 105
                },
                new CountryPhoneCodeEntity
                {
                    Id = 106,
                    Code = "00852",
                    IsoCode = "+852",
                    CountryName = "Hong Kong",
                    CountryIso2Code = "HK",
                    CountryIso3Code = "HKG",
                    IsAvailable = true,
                    Order = 106
                },
                new CountryPhoneCodeEntity
                {
                    Id = 107,
                    Code = "0036",
                    IsoCode = "+36",
                    CountryName = "Hungary",
                    CountryIso2Code = "HU",
                    CountryIso3Code = "HUN",
                    IsAvailable = true,
                    Order = 107
                },
                new CountryPhoneCodeEntity
                {
                    Id = 108,
                    Code = "00354",
                    IsoCode = "+354",
                    CountryName = "Iceland",
                    CountryIso2Code = "IS",
                    CountryIso3Code = "ISL",
                    IsAvailable = true,
                    Order = 108
                },
                new CountryPhoneCodeEntity
                {
                    Id = 109,
                    Code = "0062",
                    IsoCode = "+62",
                    CountryName = "Indonesia",
                    CountryIso2Code = "ID",
                    CountryIso3Code = "IDN",
                    IsAvailable = true,
                    Order = 109
                },
                new CountryPhoneCodeEntity
                {
                    Id = 110,
                    Code = "00353",
                    IsoCode = "+353",
                    CountryName = "Ireland",
                    CountryIso2Code = "IE",
                    CountryIso3Code = "IRL",
                    IsAvailable = true,
                    Order = 110
                },
                new CountryPhoneCodeEntity
                {
                    Id = 111,
                    Code = "0044-1624",
                    IsoCode = "+44-1624",
                    CountryName = "Isle of Man",
                    CountryIso2Code = "IM",
                    CountryIso3Code = "IMN",
                    IsAvailable = true,
                    Order = 111
                },
                new CountryPhoneCodeEntity
                {
                    Id = 112,
                    Code = "00972",
                    IsoCode = "+972",
                    CountryName = "Israel",
                    CountryIso2Code = "IL",
                    CountryIso3Code = "ISR",
                    IsAvailable = true,
                    Order = 112
                },
                new CountryPhoneCodeEntity
                {
                    Id = 113,
                    Code = "0039",
                    IsoCode = "+39",
                    CountryName = "Italy",
                    CountryIso2Code = "IT",
                    CountryIso3Code = "ITA",
                    IsAvailable = true,
                    Order = 113
                },
                new CountryPhoneCodeEntity
                {
                    Id = 114,
                    Code = "00225",
                    IsoCode = "+225",
                    CountryName = "Ivory Coast",
                    CountryIso2Code = "CI",
                    CountryIso3Code = "CIV",
                    IsAvailable = true,
                    Order = 114
                },
                new CountryPhoneCodeEntity
                {
                    Id = 115,
                    Code = "001-876",
                    IsoCode = "+1-876",
                    CountryName = "Jamaica",
                    CountryIso2Code = "JM",
                    CountryIso3Code = "JAM",
                    IsAvailable = true,
                    Order = 115
                },
                new CountryPhoneCodeEntity
                {
                    Id = 116,
                    Code = "0081",
                    IsoCode = "+81",
                    CountryName = "Japan",
                    CountryIso2Code = "JP",
                    CountryIso3Code = "JPN",
                    IsAvailable = true,
                    Order = 116
                },
                new CountryPhoneCodeEntity
                {
                    Id = 117,
                    Code = "0044-1534",
                    IsoCode = "+44-1534",
                    CountryName = "Jersey",
                    CountryIso2Code = "JE",
                    CountryIso3Code = "JEY",
                    IsAvailable = true,
                    Order = 117
                },
                new CountryPhoneCodeEntity
                {
                    Id = 118,
                    Code = "007",
                    IsoCode = "+7",
                    CountryName = "Kazakhstan",
                    CountryIso2Code = "KZ",
                    CountryIso3Code = "KAZ",
                    IsAvailable = true,
                    Order = 118
                },
                new CountryPhoneCodeEntity
                {
                    Id = 119,
                    Code = "00254",
                    IsoCode = "+254",
                    CountryName = "Kenya",
                    CountryIso2Code = "KE",
                    CountryIso3Code = "KEN",
                    IsAvailable = true,
                    Order = 119
                },
                new CountryPhoneCodeEntity
                {
                    Id = 120,
                    Code = "00686",
                    IsoCode = "+686",
                    CountryName = "Kiribati",
                    CountryIso2Code = "KI",
                    CountryIso3Code = "KIR",
                    IsAvailable = true,
                    Order = 120
                },
                new CountryPhoneCodeEntity
                {
                    Id = 121,
                    Code = "00383",
                    IsoCode = "+383",
                    CountryName = "Kosovo",
                    CountryIso2Code = "XK",
                    CountryIso3Code = "XKX",
                    IsAvailable = true,
                    Order = 121
                },
                new CountryPhoneCodeEntity
                {
                    Id = 122,
                    Code = "00996",
                    IsoCode = "+996",
                    CountryName = "Kyrgyzstan",
                    CountryIso2Code = "KG",
                    CountryIso3Code = "KGZ",
                    IsAvailable = true,
                    Order = 122
                },
                new CountryPhoneCodeEntity
                {
                    Id = 123,
                    Code = "00856",
                    IsoCode = "+856",
                    CountryName = "Laos",
                    CountryIso2Code = "LA",
                    CountryIso3Code = "LAO",
                    IsAvailable = true,
                    Order = 123
                },
                new CountryPhoneCodeEntity
                {
                    Id = 124,
                    Code = "00371",
                    IsoCode = "+371",
                    CountryName = "Latvia",
                    CountryIso2Code = "LV",
                    CountryIso3Code = "LVA",
                    IsAvailable = true,
                    Order = 124
                },
                new CountryPhoneCodeEntity
                {
                    Id = 125,
                    Code = "00266",
                    IsoCode = "+266",
                    CountryName = "Lesotho",
                    CountryIso2Code = "LS",
                    CountryIso3Code = "LSO",
                    IsAvailable = true,
                    Order = 125
                },
                new CountryPhoneCodeEntity
                {
                    Id = 126,
                    Code = "00231",
                    IsoCode = "+231",
                    CountryName = "Liberia",
                    CountryIso2Code = "LR",
                    CountryIso3Code = "LBR",
                    IsAvailable = true,
                    Order = 126
                },
                new CountryPhoneCodeEntity
                {
                    Id = 127,
                    Code = "00218",
                    IsoCode = "+218",
                    CountryName = "Libya",
                    CountryIso2Code = "LY",
                    CountryIso3Code = "LBY",
                    IsAvailable = true,
                    Order = 127
                },
                new CountryPhoneCodeEntity
                {
                    Id = 128,
                    Code = "00423",
                    IsoCode = "+423",
                    CountryName = "Liechtenstein",
                    CountryIso2Code = "LI",
                    CountryIso3Code = "LIE",
                    IsAvailable = true,
                    Order = 128
                },
                new CountryPhoneCodeEntity
                {
                    Id = 129,
                    Code = "00370",
                    IsoCode = "+370",
                    CountryName = "Lithuania",
                    CountryIso2Code = "LT",
                    CountryIso3Code = "LTU",
                    IsAvailable = true,
                    Order = 129
                },
                new CountryPhoneCodeEntity
                {
                    Id = 130,
                    Code = "00352",
                    IsoCode = "+352",
                    CountryName = "Luxembourg",
                    CountryIso2Code = "LU",
                    CountryIso3Code = "LUX",
                    IsAvailable = true,
                    Order = 130
                },
                new CountryPhoneCodeEntity
                {
                    Id = 131,
                    Code = "00853",
                    IsoCode = "+853",
                    CountryName = "Macao",
                    CountryIso2Code = "MO",
                    CountryIso3Code = "MAC",
                    IsAvailable = true,
                    Order = 131
                },
                new CountryPhoneCodeEntity
                {
                    Id = 132,
                    Code = "00389",
                    IsoCode = "+389",
                    CountryName = "Macedonia",
                    CountryIso2Code = "MK",
                    CountryIso3Code = "MKD",
                    IsAvailable = true,
                    Order = 132
                },
                new CountryPhoneCodeEntity
                {
                    Id = 133,
                    Code = "00261",
                    IsoCode = "+261",
                    CountryName = "Madagascar",
                    CountryIso2Code = "MG",
                    CountryIso3Code = "MDG",
                    IsAvailable = true,
                    Order = 133
                },
                new CountryPhoneCodeEntity
                {
                    Id = 134,
                    Code = "00265",
                    IsoCode = "+265",
                    CountryName = "Malawi",
                    CountryIso2Code = "MW",
                    CountryIso3Code = "MWI",
                    IsAvailable = true,
                    Order = 134
                },
                new CountryPhoneCodeEntity
                {
                    Id = 135,
                    Code = "0060",
                    IsoCode = "+60",
                    CountryName = "Malaysia",
                    CountryIso2Code = "MY",
                    CountryIso3Code = "MYS",
                    IsAvailable = true,
                    Order = 135
                },
                new CountryPhoneCodeEntity
                {
                    Id = 136,
                    Code = "00960",
                    IsoCode = "+960",
                    CountryName = "Maldives",
                    CountryIso2Code = "MV",
                    CountryIso3Code = "MDV",
                    IsAvailable = true,
                    Order = 136
                },
                new CountryPhoneCodeEntity
                {
                    Id = 137,
                    Code = "00223",
                    IsoCode = "+223",
                    CountryName = "Mali",
                    CountryIso2Code = "ML",
                    CountryIso3Code = "MLI",
                    IsAvailable = true,
                    Order = 137
                },
                new CountryPhoneCodeEntity
                {
                    Id = 138,
                    Code = "00356",
                    IsoCode = "+356",
                    CountryName = "Malta",
                    CountryIso2Code = "MT",
                    CountryIso3Code = "MLT",
                    IsAvailable = true,
                    Order = 138
                },
                new CountryPhoneCodeEntity
                {
                    Id = 139,
                    Code = "00692",
                    IsoCode = "+692",
                    CountryName = "Marshall Islands",
                    CountryIso2Code = "MH",
                    CountryIso3Code = "MHL",
                    IsAvailable = true,
                    Order = 139
                },
                new CountryPhoneCodeEntity
                {
                    Id = 140,
                    Code = "00222",
                    IsoCode = "+222",
                    CountryName = "Mauritania",
                    CountryIso2Code = "MR",
                    CountryIso3Code = "MRT",
                    IsAvailable = true,
                    Order = 140
                },
                new CountryPhoneCodeEntity
                {
                    Id = 141,
                    Code = "00230",
                    IsoCode = "+230",
                    CountryName = "Mauritius",
                    CountryIso2Code = "MU",
                    CountryIso3Code = "MUS",
                    IsAvailable = true,
                    Order = 141
                },
                new CountryPhoneCodeEntity
                {
                    Id = 142,
                    Code = "00262",
                    IsoCode = "+262",
                    CountryName = "Mayotte",
                    CountryIso2Code = "YT",
                    CountryIso3Code = "MYT",
                    IsAvailable = true,
                    Order = 142
                },
                new CountryPhoneCodeEntity
                {
                    Id = 143,
                    Code = "0052",
                    IsoCode = "+52",
                    CountryName = "Mexico",
                    CountryIso2Code = "MX",
                    CountryIso3Code = "MEX",
                    IsAvailable = true,
                    Order = 143
                },
                new CountryPhoneCodeEntity
                {
                    Id = 144,
                    Code = "00691",
                    IsoCode = "+691",
                    CountryName = "Micronesia",
                    CountryIso2Code = "FM",
                    CountryIso3Code = "FSM",
                    IsAvailable = true,
                    Order = 144
                },
                new CountryPhoneCodeEntity
                {
                    Id = 145,
                    Code = "00373",
                    IsoCode = "+373",
                    CountryName = "Moldova",
                    CountryIso2Code = "MD",
                    CountryIso3Code = "MDA",
                    IsAvailable = true,
                    Order = 145
                },
                new CountryPhoneCodeEntity
                {
                    Id = 146,
                    Code = "00377",
                    IsoCode = "+377",
                    CountryName = "Monaco",
                    CountryIso2Code = "MC",
                    CountryIso3Code = "MCO",
                    IsAvailable = true,
                    Order = 146
                },
                new CountryPhoneCodeEntity
                {
                    Id = 147,
                    Code = "00976",
                    IsoCode = "+976",
                    CountryName = "Mongolia",
                    CountryIso2Code = "MN",
                    CountryIso3Code = "MNG",
                    IsAvailable = true,
                    Order = 147
                },
                new CountryPhoneCodeEntity
                {
                    Id = 148,
                    Code = "00382",
                    IsoCode = "+382",
                    CountryName = "Montenegro",
                    CountryIso2Code = "ME",
                    CountryIso3Code = "MNE",
                    IsAvailable = true,
                    Order = 148
                },
                new CountryPhoneCodeEntity
                {
                    Id = 149,
                    Code = "001-664",
                    IsoCode = "+1-664",
                    CountryName = "Montserrat",
                    CountryIso2Code = "MS",
                    CountryIso3Code = "MSR",
                    IsAvailable = true,
                    Order = 149
                },
                new CountryPhoneCodeEntity
                {
                    Id = 150,
                    Code = "00212",
                    IsoCode = "+212",
                    CountryName = "Morocco",
                    CountryIso2Code = "MA",
                    CountryIso3Code = "MAR",
                    IsAvailable = true,
                    Order = 150
                },
                new CountryPhoneCodeEntity
                {
                    Id = 151,
                    Code = "00258",
                    IsoCode = "+258",
                    CountryName = "Mozambique",
                    CountryIso2Code = "MZ",
                    CountryIso3Code = "MOZ",
                    IsAvailable = true,
                    Order = 151
                },
                new CountryPhoneCodeEntity
                {
                    Id = 152,
                    Code = "0095",
                    IsoCode = "+95",
                    CountryName = "Myanmar",
                    CountryIso2Code = "MM",
                    CountryIso3Code = "MMR",
                    IsAvailable = true,
                    Order = 152
                },
                new CountryPhoneCodeEntity
                {
                    Id = 153,
                    Code = "00264",
                    IsoCode = "+264",
                    CountryName = "Namibia",
                    CountryIso2Code = "NA",
                    CountryIso3Code = "NAM",
                    IsAvailable = true,
                    Order = 153
                },
                new CountryPhoneCodeEntity
                {
                    Id = 154,
                    Code = "00674",
                    IsoCode = "+674",
                    CountryName = "Nauru",
                    CountryIso2Code = "NR",
                    CountryIso3Code = "NRU",
                    IsAvailable = true,
                    Order = 154
                },
                new CountryPhoneCodeEntity
                {
                    Id = 155,
                    Code = "00977",
                    IsoCode = "+977",
                    CountryName = "Nepal",
                    CountryIso2Code = "NP",
                    CountryIso3Code = "NPL",
                    IsAvailable = true,
                    Order = 155
                },
                new CountryPhoneCodeEntity
                {
                    Id = 156,
                    Code = "0031",
                    IsoCode = "+31",
                    CountryName = "Netherlands",
                    CountryIso2Code = "NL",
                    CountryIso3Code = "NLD",
                    IsAvailable = true,
                    Order = 156
                },
                new CountryPhoneCodeEntity
                {
                    Id = 157,
                    Code = "00599",
                    IsoCode = "+599",
                    CountryName = "Netherlands Antilles",
                    CountryIso2Code = "AN",
                    CountryIso3Code = "ANT",
                    IsAvailable = true,
                    Order = 157
                },
                new CountryPhoneCodeEntity
                {
                    Id = 158,
                    Code = "00687",
                    IsoCode = "+687",
                    CountryName = "New Caledonia",
                    CountryIso2Code = "NC",
                    CountryIso3Code = "NCL",
                    IsAvailable = true,
                    Order = 158
                },
                new CountryPhoneCodeEntity
                {
                    Id = 159,
                    Code = "0064",
                    IsoCode = "+64",
                    CountryName = "New Zealand",
                    CountryIso2Code = "NZ",
                    CountryIso3Code = "NZL",
                    IsAvailable = true,
                    Order = 159
                },
                new CountryPhoneCodeEntity
                {
                    Id = 160,
                    Code = "00505",
                    IsoCode = "+505",
                    CountryName = "Nicaragua",
                    CountryIso2Code = "NI",
                    CountryIso3Code = "NIC",
                    IsAvailable = true,
                    Order = 160
                },
                new CountryPhoneCodeEntity
                {
                    Id = 161,
                    Code = "00227",
                    IsoCode = "+227",
                    CountryName = "Niger",
                    CountryIso2Code = "NE",
                    CountryIso3Code = "NER",
                    IsAvailable = true,
                    Order = 161
                },
                new CountryPhoneCodeEntity
                {
                    Id = 162,
                    Code = "00234",
                    IsoCode = "+234",
                    CountryName = "Nigeria",
                    CountryIso2Code = "NG",
                    CountryIso3Code = "NGA",
                    IsAvailable = true,
                    Order = 162
                },
                new CountryPhoneCodeEntity
                {
                    Id = 163,
                    Code = "00683",
                    IsoCode = "+683",
                    CountryName = "Niue",
                    CountryIso2Code = "NU",
                    CountryIso3Code = "NIU",
                    IsAvailable = true,
                    Order = 163
                },
                new CountryPhoneCodeEntity
                {
                    Id = 164,
                    Code = "001-670",
                    IsoCode = "+1-670",
                    CountryName = "Northern Mariana Islands",
                    CountryIso2Code = "MP",
                    CountryIso3Code = "MNP",
                    IsAvailable = true,
                    Order = 164
                },
                new CountryPhoneCodeEntity
                {
                    Id = 165,
                    Code = "00850",
                    IsoCode = "+850",
                    CountryName = "North Korea",
                    CountryIso2Code = "KP",
                    CountryIso3Code = "PRK",
                    IsAvailable = true,
                    Order = 165
                },
                new CountryPhoneCodeEntity
                {
                    Id = 166,
                    Code = "0047",
                    IsoCode = "+47",
                    CountryName = "Norway",
                    CountryIso2Code = "NO",
                    CountryIso3Code = "NOR",
                    IsAvailable = true,
                    Order = 166
                },
                new CountryPhoneCodeEntity
                {
                    Id = 167,
                    Code = "00968",
                    IsoCode = "+968",
                    CountryName = "Oman",
                    CountryIso2Code = "OM",
                    CountryIso3Code = "OMN",
                    IsAvailable = true,
                    Order = 167
                },
                new CountryPhoneCodeEntity
                {
                    Id = 168,
                    Code = "00680",
                    IsoCode = "+680",
                    CountryName = "Palau",
                    CountryIso2Code = "PW",
                    CountryIso3Code = "PLW",
                    IsAvailable = true,
                    Order = 168
                },
                new CountryPhoneCodeEntity
                {
                    Id = 169,
                    Code = "00970",
                    IsoCode = "+970",
                    CountryName = "Palestine",
                    CountryIso2Code = "PS",
                    CountryIso3Code = "PSE",
                    IsAvailable = true,
                    Order = 169
                },
                new CountryPhoneCodeEntity
                {
                    Id = 170,
                    Code = "00507",
                    IsoCode = "+507",
                    CountryName = "Panama",
                    CountryIso2Code = "PA",
                    CountryIso3Code = "PAN",
                    IsAvailable = true,
                    Order = 170
                },
                new CountryPhoneCodeEntity
                {
                    Id = 171,
                    Code = "00675",
                    IsoCode = "+675",
                    CountryName = "Papua New Guinea",
                    CountryIso2Code = "PG",
                    CountryIso3Code = "PNG",
                    IsAvailable = true,
                    Order = 171
                },
                new CountryPhoneCodeEntity
                {
                    Id = 172,
                    Code = "00595",
                    IsoCode = "+595",
                    CountryName = "Paraguay",
                    CountryIso2Code = "PY",
                    CountryIso3Code = "PRY",
                    IsAvailable = true,
                    Order = 172
                },
                new CountryPhoneCodeEntity
                {
                    Id = 173,
                    Code = "0051",
                    IsoCode = "+51",
                    CountryName = "Peru",
                    CountryIso2Code = "PE",
                    CountryIso3Code = "PER",
                    IsAvailable = true,
                    Order = 173
                },
                new CountryPhoneCodeEntity
                {
                    Id = 174,
                    Code = "0063",
                    IsoCode = "+63",
                    CountryName = "Philippines",
                    CountryIso2Code = "PH",
                    CountryIso3Code = "PHL",
                    IsAvailable = true,
                    Order = 174
                },
                new CountryPhoneCodeEntity
                {
                    Id = 175,
                    Code = "0064",
                    IsoCode = "+64",
                    CountryName = "Pitcairn",
                    CountryIso2Code = "NZ",
                    CountryIso3Code = "NZL",
                    IsAvailable = true,
                    Order = 175
                },
                new CountryPhoneCodeEntity
                {
                    Id = 176,
                    Code = "0048",
                    IsoCode = "+48",
                    CountryName = "Poland",
                    CountryIso2Code = "PL",
                    CountryIso3Code = "POL",
                    IsAvailable = true,
                    Order = 176
                },
                new CountryPhoneCodeEntity
                {
                    Id = 177,
                    Code = "00351",
                    IsoCode = "+351",
                    CountryName = "Portugal",
                    CountryIso2Code = "PT",
                    CountryIso3Code = "PRT",
                    IsAvailable = true,
                    Order = 177
                },
                new CountryPhoneCodeEntity
                {
                    Id = 178,
                    Code = "001-787",
                    IsoCode = "+1-787",
                    CountryName = "Puerto Rico",
                    CountryIso2Code = "PR",
                    CountryIso3Code = "PRI",
                    IsAvailable = true,
                    Order = 178
                },
                new CountryPhoneCodeEntity
                {
                    Id = 179,
                    Code = "001-939",
                    IsoCode = "+1-939",
                    CountryName = "Puerto Rico",
                    CountryIso2Code = "PR",
                    CountryIso3Code = "PRI",
                    IsAvailable = true,
                    Order = 179
                },
                new CountryPhoneCodeEntity
                {
                    Id = 180,
                    Code = "00974",
                    IsoCode = "+974",
                    CountryName = "Qatar",
                    CountryIso2Code = "QA",
                    CountryIso3Code = "QAT",
                    IsAvailable = true,
                    Order = 180
                },
                new CountryPhoneCodeEntity
                {
                    Id = 181,
                    Code = "00242",
                    IsoCode = "+242",
                    CountryName = "Republic of the Congo",
                    CountryIso2Code = "CG",
                    CountryIso3Code = "COG",
                    IsAvailable = true,
                    Order = 181
                },
                new CountryPhoneCodeEntity
                {
                    Id = 182,
                    Code = "00262",
                    IsoCode = "+262",
                    CountryName = "Reunion",
                    CountryIso2Code = "RE",
                    CountryIso3Code = "REU",
                    IsAvailable = true,
                    Order = 182
                },
                new CountryPhoneCodeEntity
                {
                    Id = 183,
                    Code = "0040",
                    IsoCode = "+40",
                    CountryName = "Romania",
                    CountryIso2Code = "RO",
                    CountryIso3Code = "ROU",
                    IsAvailable = true,
                    Order = 183
                },
                new CountryPhoneCodeEntity
                {
                    Id = 184,
                    Code = "007",
                    IsoCode = "+7",
                    CountryName = "Russia",
                    CountryIso2Code = "RU",
                    CountryIso3Code = "RUS",
                    IsAvailable = true,
                    Order = 184
                },
                new CountryPhoneCodeEntity
                {
                    Id = 185,
                    Code = "00250",
                    IsoCode = "+250",
                    CountryName = "Rwanda",
                    CountryIso2Code = "RW",
                    CountryIso3Code = "RWA",
                    IsAvailable = true,
                    Order = 185
                },
                new CountryPhoneCodeEntity
                {
                    Id = 186,
                    Code = "00590",
                    IsoCode = "+590",
                    CountryName = "Saint Barthelemy",
                    CountryIso2Code = "BL",
                    CountryIso3Code = "BLM",
                    IsAvailable = true,
                    Order = 186
                },
                new CountryPhoneCodeEntity
                {
                    Id = 187,
                    Code = "00290",
                    IsoCode = "+290",
                    CountryName = "Saint Helena",
                    CountryIso2Code = "SH",
                    CountryIso3Code = "SHN",
                    IsAvailable = true,
                    Order = 187
                },
                new CountryPhoneCodeEntity
                {
                    Id = 188,
                    Code = "001-869",
                    IsoCode = "+1-869",
                    CountryName = "Saint Kitts and Nevis",
                    CountryIso2Code = "KN",
                    CountryIso3Code = "KNA",
                    IsAvailable = true,
                    Order = 188
                },
                new CountryPhoneCodeEntity
                {
                    Id = 189,
                    Code = "001-758",
                    IsoCode = "+1-758",
                    CountryName = "Saint Lucia",
                    CountryIso2Code = "LC",
                    CountryIso3Code = "LCA",
                    IsAvailable = true,
                    Order = 189
                },
                new CountryPhoneCodeEntity
                {
                    Id = 190,
                    Code = "00590",
                    IsoCode = "+590",
                    CountryName = "Saint Martin",
                    CountryIso2Code = "MF",
                    CountryIso3Code = "MAF",
                    IsAvailable = true,
                    Order = 190
                },
                new CountryPhoneCodeEntity
                {
                    Id = 191,
                    Code = "00508",
                    IsoCode = "+508",
                    CountryName = "Saint Pierre and Miquelon",
                    CountryIso2Code = "PM",
                    CountryIso3Code = "SPM",
                    IsAvailable = true,
                    Order = 191
                },
                new CountryPhoneCodeEntity
                {
                    Id = 192,
                    Code = "001-784",
                    IsoCode = "+1-784",
                    CountryName = "Saint Vincent and the Grenadines",
                    CountryIso2Code = "VC",
                    CountryIso3Code = "VCT",
                    IsAvailable = true,
                    Order = 192
                },
                new CountryPhoneCodeEntity
                {
                    Id = 193,
                    Code = "00685",
                    IsoCode = "+685",
                    CountryName = "Samoa",
                    CountryIso2Code = "WS",
                    CountryIso3Code = "WSM",
                    IsAvailable = true,
                    Order = 193
                },
                new CountryPhoneCodeEntity
                {
                    Id = 194,
                    Code = "00378",
                    IsoCode = "+378",
                    CountryName = "San Marino",
                    CountryIso2Code = "SM",
                    CountryIso3Code = "SMR",
                    IsAvailable = true,
                    Order = 194
                },
                new CountryPhoneCodeEntity
                {
                    Id = 195,
                    Code = "00239",
                    IsoCode = "+239",
                    CountryName = "Sao Tome and Principe",
                    CountryIso2Code = "ST",
                    CountryIso3Code = "STP",
                    IsAvailable = true,
                    Order = 195
                },
                new CountryPhoneCodeEntity
                {
                    Id = 196,
                    Code = "00221",
                    IsoCode = "+221",
                    CountryName = "Senegal",
                    CountryIso2Code = "SN",
                    CountryIso3Code = "SEN",
                    IsAvailable = true,
                    Order = 196
                },
                new CountryPhoneCodeEntity
                {
                    Id = 197,
                    Code = "00381",
                    IsoCode = "+381",
                    CountryName = "Serbia",
                    CountryIso2Code = "RS",
                    CountryIso3Code = "SRB",
                    IsAvailable = true,
                    Order = 197
                },
                new CountryPhoneCodeEntity
                {
                    Id = 198,
                    Code = "00248",
                    IsoCode = "+248",
                    CountryName = "Seychelles",
                    CountryIso2Code = "SC",
                    CountryIso3Code = "SYC",
                    IsAvailable = true,
                    Order = 198
                },
                new CountryPhoneCodeEntity
                {
                    Id = 199,
                    Code = "00232",
                    IsoCode = "+232",
                    CountryName = "Sierra Leone",
                    CountryIso2Code = "SL",
                    CountryIso3Code = "SLE",
                    IsAvailable = true,
                    Order = 199
                },
                new CountryPhoneCodeEntity
                {
                    Id = 200,
                    Code = "0065",
                    IsoCode = "+65",
                    CountryName = "Singapore",
                    CountryIso2Code = "SG",
                    CountryIso3Code = "SGP",
                    IsAvailable = true,
                    Order = 200
                },
                new CountryPhoneCodeEntity
                {
                    Id = 201,
                    Code = "001-721",
                    IsoCode = "+1-721",
                    CountryName = "Sint Maarten",
                    CountryIso2Code = "SX",
                    CountryIso3Code = "SXM",
                    IsAvailable = true,
                    Order = 201
                },
                new CountryPhoneCodeEntity
                {
                    Id = 202,
                    Code = "00421",
                    IsoCode = "+421",
                    CountryName = "Slovakia",
                    CountryIso2Code = "SK",
                    CountryIso3Code = "SVK",
                    IsAvailable = true,
                    Order = 202
                },
                new CountryPhoneCodeEntity
                {
                    Id = 203,
                    Code = "00386",
                    IsoCode = "+386",
                    CountryName = "Slovenia",
                    CountryIso2Code = "SI",
                    CountryIso3Code = "SVN",
                    IsAvailable = true,
                    Order = 203
                },
                new CountryPhoneCodeEntity
                {
                    Id = 204,
                    Code = "00677",
                    IsoCode = "+677",
                    CountryName = "Solomon Islands",
                    CountryIso2Code = "SB",
                    CountryIso3Code = "SLB",
                    IsAvailable = true,
                    Order = 204
                },
                new CountryPhoneCodeEntity
                {
                    Id = 205,
                    Code = "00252",
                    IsoCode = "+252",
                    CountryName = "Somalia",
                    CountryIso2Code = "SO",
                    CountryIso3Code = "SOM",
                    IsAvailable = true,
                    Order = 205
                },
                new CountryPhoneCodeEntity
                {
                    Id = 206,
                    Code = "0027",
                    IsoCode = "+27",
                    CountryName = "South Africa",
                    CountryIso2Code = "ZA",
                    CountryIso3Code = "ZAF",
                    IsAvailable = true,
                    Order = 206
                },
                new CountryPhoneCodeEntity
                {
                    Id = 207,
                    Code = "0082",
                    IsoCode = "+82",
                    CountryName = "South Korea",
                    CountryIso2Code = "KR",
                    CountryIso3Code = "KOR",
                    IsAvailable = true,
                    Order = 207
                },
                new CountryPhoneCodeEntity
                {
                    Id = 208,
                    Code = "00211",
                    IsoCode = "+211",
                    CountryName = "South Sudan",
                    CountryIso2Code = "SS",
                    CountryIso3Code = "SSD",
                    IsAvailable = true,
                    Order = 208
                },
                new CountryPhoneCodeEntity
                {
                    Id = 209,
                    Code = "0034",
                    IsoCode = "+34",
                    CountryName = "Spain",
                    CountryIso2Code = "ES",
                    CountryIso3Code = "ESP",
                    IsAvailable = true,
                    Order = 209
                },
                new CountryPhoneCodeEntity
                {
                    Id = 210,
                    Code = "0094",
                    IsoCode = "+94",
                    CountryName = "Sri Lanka",
                    CountryIso2Code = "LK",
                    CountryIso3Code = "LKA",
                    IsAvailable = true,
                    Order = 210
                },
                new CountryPhoneCodeEntity
                {
                    Id = 211,
                    Code = "00597",
                    IsoCode = "+597",
                    CountryName = "Suriname",
                    CountryIso2Code = "SR",
                    CountryIso3Code = "SUR",
                    IsAvailable = true,
                    Order = 211
                },
                new CountryPhoneCodeEntity
                {
                    Id = 212,
                    Code = "0047",
                    IsoCode = "+47",
                    CountryName = "Svalbard and Jan Mayen",
                    CountryIso2Code = "NO",
                    CountryIso3Code = "NOR",
                    IsAvailable = true,
                    Order = 212
                },
                new CountryPhoneCodeEntity
                {
                    Id = 213,
                    Code = "00268",
                    IsoCode = "+268",
                    CountryName = "Swaziland",
                    CountryIso2Code = "SZ",
                    CountryIso3Code = "SWZ",
                    IsAvailable = true,
                    Order = 213
                },
                new CountryPhoneCodeEntity
                {
                    Id = 214,
                    Code = "0046",
                    IsoCode = "+46",
                    CountryName = "Sweden",
                    CountryIso2Code = "SE",
                    CountryIso3Code = "SWE",
                    IsAvailable = true,
                    Order = 214
                },
                new CountryPhoneCodeEntity
                {
                    Id = 215,
                    Code = "0041",
                    IsoCode = "+41",
                    CountryName = "Switzerland",
                    CountryIso2Code = "CH",
                    CountryIso3Code = "CHE",
                    IsAvailable = true,
                    Order = 215
                },
                new CountryPhoneCodeEntity
                {
                    Id = 216,
                    Code = "00886",
                    IsoCode = "+886",
                    CountryName = "Taiwan",
                    CountryIso2Code = "TW",
                    CountryIso3Code = "TWN",
                    IsAvailable = true,
                    Order = 216
                },
                new CountryPhoneCodeEntity
                {
                    Id = 217,
                    Code = "00992",
                    IsoCode = "+992",
                    CountryName = "Tajikistan",
                    CountryIso2Code = "TJ",
                    CountryIso3Code = "TJK",
                    IsAvailable = true,
                    Order = 217
                },
                new CountryPhoneCodeEntity
                {
                    Id = 218,
                    Code = "00255",
                    IsoCode = "+255",
                    CountryName = "Tanzania",
                    CountryIso2Code = "TZ",
                    CountryIso3Code = "TZA",
                    IsAvailable = true,
                    Order = 218
                },
                new CountryPhoneCodeEntity
                {
                    Id = 219,
                    Code = "0066",
                    IsoCode = "+66",
                    CountryName = "Thailand",
                    CountryIso2Code = "TH",
                    CountryIso3Code = "THA",
                    IsAvailable = true,
                    Order = 219
                },
                new CountryPhoneCodeEntity
                {
                    Id = 220,
                    Code = "00228",
                    IsoCode = "+228",
                    CountryName = "Togo",
                    CountryIso2Code = "TG",
                    CountryIso3Code = "TGO",
                    IsAvailable = true,
                    Order = 220
                },
                new CountryPhoneCodeEntity
                {
                    Id = 221,
                    Code = "00690",
                    IsoCode = "+690",
                    CountryName = "Tokelau",
                    CountryIso2Code = "TK",
                    CountryIso3Code = "TKL",
                    IsAvailable = true,
                    Order = 221
                },
                new CountryPhoneCodeEntity
                {
                    Id = 222,
                    Code = "00676",
                    IsoCode = "+676",
                    CountryName = "Tonga",
                    CountryIso2Code = "TO",
                    CountryIso3Code = "TON",
                    IsAvailable = true,
                    Order = 222
                },
                new CountryPhoneCodeEntity
                {
                    Id = 223,
                    Code = "001-868",
                    IsoCode = "+1-868",
                    CountryName = "Trinidad and Tobago",
                    CountryIso2Code = "TT",
                    CountryIso3Code = "TTO",
                    IsAvailable = true,
                    Order = 223
                },
                new CountryPhoneCodeEntity
                {
                    Id = 224,
                    Code = "00216",
                    IsoCode = "+216",
                    CountryName = "Tunisia",
                    CountryIso2Code = "TN",
                    CountryIso3Code = "TUN",
                    IsAvailable = true,
                    Order = 224
                },
                new CountryPhoneCodeEntity
                {
                    Id = 225,
                    Code = "0090",
                    IsoCode = "+90",
                    CountryName = "Turkey",
                    CountryIso2Code = "TR",
                    CountryIso3Code = "TUR",
                    IsAvailable = true,
                    Order = 225
                },
                new CountryPhoneCodeEntity
                {
                    Id = 226,
                    Code = "00993",
                    IsoCode = "+993",
                    CountryName = "Turkmenistan",
                    CountryIso2Code = "TM",
                    CountryIso3Code = "TKM",
                    IsAvailable = true,
                    Order = 226
                },
                new CountryPhoneCodeEntity
                {
                    Id = 227,
                    Code = "001-649",
                    IsoCode = "+1-649",
                    CountryName = "Turks and Caicos Islands",
                    CountryIso2Code = "TC",
                    CountryIso3Code = "TCA",
                    IsAvailable = true,
                    Order = 227
                },
                new CountryPhoneCodeEntity
                {
                    Id = 228,
                    Code = "00688",
                    IsoCode = "+688",
                    CountryName = "Tuvalu",
                    CountryIso2Code = "TV",
                    CountryIso3Code = "TUV",
                    IsAvailable = true,
                    Order = 228
                },
                new CountryPhoneCodeEntity
                {
                    Id = 229,
                    Code = "001-340",
                    IsoCode = "+1-340",
                    CountryName = "U.S. Virgin Islands",
                    CountryIso2Code = "VI",
                    CountryIso3Code = "VIR",
                    IsAvailable = true,
                    Order = 229
                },
                new CountryPhoneCodeEntity
                {
                    Id = 230,
                    Code = "00256",
                    IsoCode = "+256",
                    CountryName = "Uganda",
                    CountryIso2Code = "UG",
                    CountryIso3Code = "UGA",
                    IsAvailable = true,
                    Order = 230
                },
                new CountryPhoneCodeEntity
                {
                    Id = 231,
                    Code = "00380",
                    IsoCode = "+380",
                    CountryName = "Ukraine",
                    CountryIso2Code = "UA",
                    CountryIso3Code = "UKR",
                    IsAvailable = true,
                    Order = 231
                },
                new CountryPhoneCodeEntity
                {
                    Id = 232,
                    Code = "00598",
                    IsoCode = "+598",
                    CountryName = "Uruguay",
                    CountryIso2Code = "UY",
                    CountryIso3Code = "URY",
                    IsAvailable = true,
                    Order = 232
                },
                new CountryPhoneCodeEntity
                {
                    Id = 233,
                    Code = "00998",
                    IsoCode = "+998",
                    CountryName = "Uzbekistan",
                    CountryIso2Code = "UZ",
                    CountryIso3Code = "UZB",
                    IsAvailable = true,
                    Order = 233
                },
                new CountryPhoneCodeEntity
                {
                    Id = 234,
                    Code = "00678",
                    IsoCode = "+678",
                    CountryName = "Vanuatu",
                    CountryIso2Code = "VU",
                    CountryIso3Code = "VUT",
                    IsAvailable = true,
                    Order = 234
                },
                new CountryPhoneCodeEntity
                {
                    Id = 235,
                    Code = "00379",
                    IsoCode = "+379",
                    CountryName = "Vatican",
                    CountryIso2Code = "VA",
                    CountryIso3Code = "VAT",
                    IsAvailable = true,
                    Order = 235
                },
                new CountryPhoneCodeEntity
                {
                    Id = 236,
                    Code = "0058",
                    IsoCode = "+58",
                    CountryName = "Venezuela",
                    CountryIso2Code = "VE",
                    CountryIso3Code = "VEN",
                    IsAvailable = true,
                    Order = 236
                },
                new CountryPhoneCodeEntity
                {
                    Id = 237,
                    Code = "0084",
                    IsoCode = "+84",
                    CountryName = "Vietnam",
                    CountryIso2Code = "VN",
                    CountryIso3Code = "VNM",
                    IsAvailable = true,
                    Order = 237
                },
                new CountryPhoneCodeEntity
                {
                    Id = 238,
                    Code = "00681",
                    IsoCode = "+681",
                    CountryName = "Wallis and Futuna",
                    CountryIso2Code = "WF",
                    CountryIso3Code = "WLF",
                    IsAvailable = true,
                    Order = 238
                },
                new CountryPhoneCodeEntity
                {
                    Id = 239,
                    Code = "00212",
                    IsoCode = "+212",
                    CountryName = "Western Sahara",
                    CountryIso2Code = "MA",
                    CountryIso3Code = "MAR",
                    IsAvailable = true,
                    Order = 239
                },
                new CountryPhoneCodeEntity
                {
                    Id = 240,
                    Code = "00967",
                    IsoCode = "+967",
                    CountryName = "Yemen",
                    CountryIso2Code = "YE",
                    CountryIso3Code = "YEM",
                    IsAvailable = true,
                    Order = 240
                },
                new CountryPhoneCodeEntity
                {
                    Id = 241,
                    Code = "00260",
                    IsoCode = "+260",
                    CountryName = "Zambia",
                    CountryIso2Code = "ZM",
                    CountryIso3Code = "ZMB",
                    IsAvailable = true,
                    Order = 241
                },
                new CountryPhoneCodeEntity
                {
                    Id = 242,
                    Code = "00263",
                    IsoCode = "+263",
                    CountryName = "Zimbabwe",
                    CountryIso2Code = "ZW",
                    CountryIso3Code = "ZWE",
                    IsAvailable = true,
                    Order = 242
                },
                new CountryPhoneCodeEntity
                {
                    Id = 243,
                    Code = "00971",
                    IsoCode = "+971",
                    CountryName = "United Arab Emirates",
                    CountryIso2Code = "AE",
                    CountryIso3Code = "ARE",
                    IsAvailable = true,
                    Order = 0
                }
            };

        internal static IReadOnlyList<EmailNotificationPropertiesEntity> GetEmailNotificationProperty()
        {
            return new[]
            {
                new EmailNotificationPropertiesEntity()
                {
                    Id = 1,
                    FacebookLink = "https://www.facebook.com/MVNToken-101312831304651/",
                    InstagramLink = "https://www.instagram.com/mvntoken/",
                    DownloadAppLink = "https://apadmanabhan1.wixsite.com/eapp",
                    LinkedInLink = "#",
                    PrivacyPolicyLink = "https://mvntoken.mavn.com/en/policy",
                    TermsAndConditionLink = "https://mvntoken.mavn.com/en/terms",
                    TwitterLink = "https://twitter.com/MVNtoken",
                    UnsubscribeLink = "#",
                    YouTubeLink = "#",
                    DownloadAndroidAppLink = "https://play.google.com/store/apps/details?id=com.mavntechnologies.communitytoken",
                    DownloadIsoAppLink = "http://itunes.apple.com/app/id1470065092"
                }
            };
        }
    }
}
