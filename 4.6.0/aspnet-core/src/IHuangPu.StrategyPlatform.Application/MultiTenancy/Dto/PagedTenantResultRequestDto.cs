using Abp.Application.Services.Dto;

namespace IHuangPu.StrategyPlatform.MultiTenancy.Dto
{
    public class PagedTenantResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

