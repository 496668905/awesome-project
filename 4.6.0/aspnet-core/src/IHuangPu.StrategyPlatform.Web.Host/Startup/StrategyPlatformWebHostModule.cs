using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IHuangPu.StrategyPlatform.Configuration;

namespace IHuangPu.StrategyPlatform.Web.Host.Startup
{
    [DependsOn(
       typeof(StrategyPlatformWebCoreModule))]
    public class StrategyPlatformWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public StrategyPlatformWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(StrategyPlatformWebHostModule).GetAssembly());
        }
    }
}
