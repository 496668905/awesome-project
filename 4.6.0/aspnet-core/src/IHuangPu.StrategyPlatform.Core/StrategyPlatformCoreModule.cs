using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Abp.Zero.Configuration;
using IHuangPu.StrategyPlatform.Authorization.Roles;
using IHuangPu.StrategyPlatform.Authorization.Users;
using IHuangPu.StrategyPlatform.Configuration;
using IHuangPu.StrategyPlatform.Localization;
using IHuangPu.StrategyPlatform.MultiTenancy;
using IHuangPu.StrategyPlatform.Timing;

namespace IHuangPu.StrategyPlatform
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class StrategyPlatformCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            // Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            StrategyPlatformLocalizationConfigurer.Configure(Configuration.Localization);

            // Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = StrategyPlatformConsts.MultiTenancyEnabled;

            // Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StrategyPlatformCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}
