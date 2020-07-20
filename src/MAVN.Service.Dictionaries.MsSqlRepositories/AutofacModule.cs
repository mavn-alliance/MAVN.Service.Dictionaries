using Autofac;
using MAVN.Persistence.PostgreSQL.Legacy;
using MAVN.Service.Dictionaries.Domain.Repositories;
using MAVN.Service.Dictionaries.MsSqlRepositories.Contexts;
using MAVN.Service.Dictionaries.MsSqlRepositories.Repositories;

namespace MAVN.Service.Dictionaries.MsSqlRepositories
{
    public class AutofacModule : Module
    {
        private readonly string _connectionString;

        public AutofacModule(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterPostgreSQL(
                _connectionString,
                connString => new DataContext(connString, false),
                dbConn => new DataContext(dbConn));

            builder.RegisterType<CountryOfResidenceRepository>()
                .As<ICountryOfResidenceRepository>()
                .SingleInstance();

            builder.RegisterType<CountryPhoneCodeRepository>()
                .As<ICountryPhoneCodeRepository>()
                .SingleInstance();

            builder.RegisterType<NotificationRepository>()
                .As<INotificationRepository>()
                .SingleInstance();
        }
    }
}
