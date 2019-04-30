using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IHuangPu.StrategyPlatform.EntityFrameworkCore
{
    public static class StrategyPlatformDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<StrategyPlatformDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<StrategyPlatformDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
