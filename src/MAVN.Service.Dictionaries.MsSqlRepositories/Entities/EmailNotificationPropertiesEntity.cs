using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Entities
{
    [Table("email_notifications_properties")]
    public class EmailNotificationPropertiesEntity
    {
        [Key]
        [Column("id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Column("facebook_link", TypeName = "varchar(200)")]
        public string FacebookLink { get; set; }

        [Required]
        [Column("twitter_link", TypeName = "varchar(200)")]
        public string TwitterLink { get; set; }

        [Required]
        [Column("instagram_link", TypeName = "varchar(200)")]
        public string InstagramLink { get; set; }

        [Required]
        [Column("linkedin_link", TypeName = "varchar(200)")]
        public string LinkedInLink { get; set; }

        [Required]
        [Column("youtube_link", TypeName = "varchar(200)")]
        public string YouTubeLink { get; set; }

        [Required]
        [Column("download_app_link", TypeName = "varchar(200)")]
        public string DownloadAppLink { get; set; }

        [Required]
        [Column("terms_and_conditions_link", TypeName = "varchar(200)")]
        public string TermsAndConditionLink { get; set; }

        [Required]
        [Column("privacy_policy_link", TypeName = "varchar(200)")]
        public string PrivacyPolicyLink { get; set; }

        [Required]
        [Column("unsubscribe_link", TypeName = "varchar(200)")]
        public string UnsubscribeLink { get; set; }

        [Required]
        [Column("download_android_app_link", TypeName = "varchar(300)")]
        public string DownloadAndroidAppLink { get; set; }

        [Required]
        [Column("download_iso_app_link", TypeName = "varchar(300)")]
        public string DownloadIsoAppLink { get; set; }
    }
}
