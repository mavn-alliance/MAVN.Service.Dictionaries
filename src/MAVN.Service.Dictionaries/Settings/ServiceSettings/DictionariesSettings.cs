using JetBrains.Annotations;
using MAVN.Service.Dictionaries.Settings.ServiceSettings.Db;

namespace MAVN.Service.Dictionaries.Settings.ServiceSettings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class DictionariesSettings
    {
        public DbSettings Db { get; set; }

        public CommonSettings Common { get; set; }
    }
}
