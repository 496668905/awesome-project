using System.Threading.Tasks;
using Abp.Application.Services;
using IHuangPu.StrategyPlatform.Sessions.Dto;

namespace IHuangPu.StrategyPlatform.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
