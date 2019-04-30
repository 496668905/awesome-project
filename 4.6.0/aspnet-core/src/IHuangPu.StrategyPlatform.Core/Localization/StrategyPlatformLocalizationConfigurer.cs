using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace IHuangPu.StrategyPlatform.Localization
{
    public static class StrategyPlatformLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(StrategyPlatformConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(StrategyPlatformLocalizationConfigurer).GetAssembly(),
                        "IHuangPu.StrategyPlatform.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
