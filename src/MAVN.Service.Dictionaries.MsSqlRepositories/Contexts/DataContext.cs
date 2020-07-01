using System.Data.Common;
using JetBrains.Annotations;
using MAVN.Persistence.PostgreSQL.Legacy;
using MAVN.Service.Dictionaries.MsSqlRepositories.Entities;
using Microsoft.EntityFrameworkCore;

namespace MAVN.Service.Dictionaries.MsSqlRepositories.Contexts
{
    public class DataContext : PostgreSQLContext
    {
        private const string Schema = "dictionaries";

        internal DbSet<CountryOfResidenceEntity> CountriesOfResidence { get; set; }
        internal DbSet<CountryPhoneCodeEntity> CountryPhoneCodes { get; set; }
        internal DbSet<EmailNotificationPropertiesEntity> EmailNotificationProperties { get; set; }

        // Used for EF migrations
        [UsedImplicitly]
        public DataContext()
            : base(Schema)
        {
        }

        public DataContext(string connectionString, bool isTraceEnabled)
            : base(Schema, connectionString, isTraceEnabled)
        {
        }

        public DataContext(DbConnection dbConnection)
            : base(Schema, dbConnection)
        {
        }

        protected override void OnMAVNModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CountryOfResidenceEntity>()
                .HasData(InitialData.GetCountriesOrResidence());

            modelBuilder.Entity<CountryPhoneCodeEntity>()
                .HasData(InitialData.GetCountryPhoneCodes());

            modelBuilder.Entity<EmailNotificationPropertiesEntity>()
                .HasData(InitialData.GetEmailNotificationProperty());
        }
    }
}
