using System.Threading.Tasks;
using IHuangPu.StrategyPlatform.Configuration.Dto;

namespace IHuangPu.StrategyPlatform.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
