using JetBrains.Annotations;
using Lykke.Sdk.Settings;
using Lykke.Service.Dictionaries.Settings.ServiceSettings;

namespace Lykke.Service.Dictionaries.Settings
{
    [UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
    public class AppSettings : BaseAppSettings
    {
        public DictionariesSettings DictionariesService { get; set; }
    }
}
