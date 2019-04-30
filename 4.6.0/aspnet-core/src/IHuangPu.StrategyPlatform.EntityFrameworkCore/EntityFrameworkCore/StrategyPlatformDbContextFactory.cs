using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using IHuangPu.StrategyPlatform.Configuration;
using IHuangPu.StrategyPlatform.Web;

namespace IHuangPu.StrategyPlatform.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class StrategyPlatformDbContextFactory : IDesignTimeDbContextFactory<StrategyPlatformDbContext>
    {
        public StrategyPlatformDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<StrategyPlatformDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            StrategyPlatformDbContextConfigurer.Configure(builder, configuration.GetConnectionString(StrategyPlatformConsts.ConnectionStringName));

            return new StrategyPlatformDbContext(builder.Options);
        }
    }
}
