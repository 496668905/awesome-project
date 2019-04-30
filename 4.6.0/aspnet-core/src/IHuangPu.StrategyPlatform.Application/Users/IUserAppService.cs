using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using IHuangPu.StrategyPlatform.Roles.Dto;
using IHuangPu.StrategyPlatform.Users.Dto;

namespace IHuangPu.StrategyPlatform.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedUserResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
