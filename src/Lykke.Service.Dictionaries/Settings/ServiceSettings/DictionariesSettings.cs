using JetBrains.Annotations;
using Lykke.Service.Dictionaries.Settings.ServiceSettings.Db;

namespace Lykke.Service.Dictionaries.Settings.ServiceSettings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class DictionariesSettings
    {
        public DbSettings Db { get; set; }

        public CommonSettings Common { get; set; }
    }
}
