using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Entities
{
    [Table("country_phone_codes")]
    public class CountryPhoneCodeEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("code", TypeName = "varchar(9)")]
        public string Code { get; set; }

        [Required]
        [Column("iso_phone_code", TypeName = "varchar(9)")]
        public string IsoCode { get; set; }

        [Required]
        [Column("country_name", TypeName = "varchar(90)")]
        public string CountryName { get; set; }

        [Required]
        [Column("country_iso2_code", TypeName = "char(2)")]
        public string CountryIso2Code { get; set; }

        [Required]
        [Column("country_iso3_code", TypeName = "char(3)")]
        public string CountryIso3Code { get; set; }

        [Required]
        [Column("is_available")]
        public bool IsAvailable { get; set; }

        [Required]
        [Column("order")]
        public ushort Order { get; set; }
    }
}
