using System.Collections.Generic;

namespace IHuangPu.StrategyPlatform.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
