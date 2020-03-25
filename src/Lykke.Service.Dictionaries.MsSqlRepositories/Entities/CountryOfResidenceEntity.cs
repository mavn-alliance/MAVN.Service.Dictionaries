using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lykke.Service.Dictionaries.MsSqlRepositories.Entities
{
    [Table("countries_of_residence")]
    public class CountryOfResidenceEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("name", TypeName = "varchar(90)")]
        public string Name { get; set; }

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
