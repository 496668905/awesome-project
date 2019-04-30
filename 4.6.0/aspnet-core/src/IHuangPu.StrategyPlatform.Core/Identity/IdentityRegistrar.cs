using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using IHuangPu.StrategyPlatform.Authorization;
using IHuangPu.StrategyPlatform.Authorization.Roles;
using IHuangPu.StrategyPlatform.Authorization.Users;
using IHuangPu.StrategyPlatform.Editions;
using IHuangPu.StrategyPlatform.MultiTenancy;

namespace IHuangPu.StrategyPlatform.Identity
{
    public static class IdentityRegistrar
    {
        public static IdentityBuilder Register(IServiceCollection services)
        {
            services.AddLogging();

            return services.AddAbpIdentity<Tenant, User, Role>()
                .AddAbpTenantManager<TenantManager>()
                .AddAbpUserManager<UserManager>()
                .AddAbpRoleManager<RoleManager>()
                .AddAbpEditionManager<EditionManager>()
                .AddAbpUserStore<UserStore>()
                .AddAbpRoleStore<RoleStore>()
                .AddAbpLogInManager<LogInManager>()
                .AddAbpSignInManager<SignInManager>()
                .AddAbpSecurityStampValidator<SecurityStampValidator>()
                .AddAbpUserClaimsPrincipalFactory<UserClaimsPrincipalFactory>()
                .AddPermissionChecker<PermissionChecker>()
                .AddDefaultTokenProviders();
        }
    }
}
