using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using IHuangPu.StrategyPlatform.Configuration.Dto;

namespace IHuangPu.StrategyPlatform.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : StrategyPlatformAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
