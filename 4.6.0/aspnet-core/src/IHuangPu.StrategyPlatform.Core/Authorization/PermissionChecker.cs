using Abp.Authorization;
using IHuangPu.StrategyPlatform.Authorization.Roles;
using IHuangPu.StrategyPlatform.Authorization.Users;

namespace IHuangPu.StrategyPlatform.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
