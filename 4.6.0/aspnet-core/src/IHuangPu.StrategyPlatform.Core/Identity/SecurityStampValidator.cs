using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Abp.Authorization;
using IHuangPu.StrategyPlatform.Authorization.Roles;
using IHuangPu.StrategyPlatform.Authorization.Users;
using IHuangPu.StrategyPlatform.MultiTenancy;

namespace IHuangPu.StrategyPlatform.Identity
{
    public class SecurityStampValidator : AbpSecurityStampValidator<Tenant, Role, User>
    {
        public SecurityStampValidator(
            IOptions<SecurityStampValidatorOptions> options, 
            SignInManager signInManager,
            ISystemClock systemClock) 
            : base(
                  options, 
                  signInManager, 
                  systemClock)
        {
        }
    }
}
