using Autofac;
using Lykke.Common.MsSql;
using Lykke.Service.Dictionaries.Domain.Repositories;
using Lykke.Service.Dictionaries.MsSqlRepositories.Contexts;
using Lykke.Service.Dictionaries.MsSqlRepositories.Repositories;

namespace Lykke.Service.Dictionaries.MsSqlRepositories
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
            builder.RegisterMsSql(
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
