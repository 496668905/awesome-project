using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IHuangPu.StrategyPlatform.Authorization;

namespace IHuangPu.StrategyPlatform
{
    [DependsOn(
        typeof(StrategyPlatformCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class StrategyPlatformApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<StrategyPlatformAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(StrategyPlatformApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
