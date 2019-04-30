using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace IHuangPu.StrategyPlatform.Controllers
{
    public abstract class StrategyPlatformControllerBase: AbpController
    {
        protected StrategyPlatformControllerBase()
        {
            LocalizationSourceName = StrategyPlatformConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
