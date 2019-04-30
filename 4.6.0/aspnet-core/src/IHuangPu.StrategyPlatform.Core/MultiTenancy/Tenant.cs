using Abp.MultiTenancy;
using IHuangPu.StrategyPlatform.Authorization.Users;

namespace IHuangPu.StrategyPlatform.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
