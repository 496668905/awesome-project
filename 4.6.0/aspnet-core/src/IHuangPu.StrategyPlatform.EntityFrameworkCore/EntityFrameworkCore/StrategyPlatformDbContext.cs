using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IHuangPu.StrategyPlatform.Authorization.Roles;
using IHuangPu.StrategyPlatform.Authorization.Users;
using IHuangPu.StrategyPlatform.MultiTenancy;

namespace IHuangPu.StrategyPlatform.EntityFrameworkCore
{
    public class StrategyPlatformDbContext : AbpZeroDbContext<Tenant, Role, User, StrategyPlatformDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public StrategyPlatformDbContext(DbContextOptions<StrategyPlatformDbContext> options)
            : base(options)
        {
        }
    }
}
