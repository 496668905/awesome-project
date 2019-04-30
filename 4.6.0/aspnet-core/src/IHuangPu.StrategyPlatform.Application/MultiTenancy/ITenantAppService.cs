using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IHuangPu.StrategyPlatform.MultiTenancy.Dto;

namespace IHuangPu.StrategyPlatform.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

