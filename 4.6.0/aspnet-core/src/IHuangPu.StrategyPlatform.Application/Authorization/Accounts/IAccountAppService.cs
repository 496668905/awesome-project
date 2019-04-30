using System.Threading.Tasks;
using Abp.Application.Services;
using IHuangPu.StrategyPlatform.Authorization.Accounts.Dto;

namespace IHuangPu.StrategyPlatform.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
