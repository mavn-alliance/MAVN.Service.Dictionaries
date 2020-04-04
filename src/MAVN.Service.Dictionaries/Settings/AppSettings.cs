using JetBrains.Annotations;
using Lykke.Sdk.Settings;
using MAVN.Service.Dictionaries.Settings.ServiceSettings;

namespace MAVN.Service.Dictionaries.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public DictionariesSettings DictionariesService { get; set; }
    }
}
