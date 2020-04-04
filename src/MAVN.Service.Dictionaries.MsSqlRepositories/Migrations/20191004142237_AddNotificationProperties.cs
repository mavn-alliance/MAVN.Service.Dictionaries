using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Migrations
{
    public partial class AddNotificationProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "email_notifications_properties",
                schema: "dictionaries",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    support_phone_number = table.Column<string>(type: "varchar(90)", nullable: false),
                    facebook_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    twitter_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    instagram_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    linkedin_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    youtube_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    download_app_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    terms_and_conditions_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    privacy_policy_link = table.Column<string>(type: "varchar(200)", nullable: false),
                    unsubscribe_link = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email_notifications_properties", x => x.id);
                });

            migrationBuilder.InsertData(
                schema: "dictionaries",
                table: "email_notifications_properties",
                columns: new[] { "id", "download_app_link", "facebook_link", "instagram_link", "linkedin_link", "privacy_policy_link", "support_phone_number", "terms_and_conditions_link", "twitter_link", "unsubscribe_link", "youtube_link" },
                values: new object[] { 1, "#", "#", "#", "#", "#", "+97144238830", "#", "#", "#", "#" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "email_notifications_properties",
                schema: "dictionaries");
        }
    }
}
