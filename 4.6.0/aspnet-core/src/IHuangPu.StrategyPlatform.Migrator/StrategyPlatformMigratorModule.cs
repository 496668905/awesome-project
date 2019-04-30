using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IHuangPu.StrategyPlatform.Configuration;
using IHuangPu.StrategyPlatform.EntityFrameworkCore;
using IHuangPu.StrategyPlatform.Migrator.DependencyInjection;

namespace IHuangPu.StrategyPlatform.Migrator
{
    [DependsOn(typeof(StrategyPlatformEntityFrameworkModule))]
    public class StrategyPlatformMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public StrategyPlatformMigratorModule(StrategyPlatformEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(StrategyPlatformMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                StrategyPlatformConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StrategyPlatformMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
