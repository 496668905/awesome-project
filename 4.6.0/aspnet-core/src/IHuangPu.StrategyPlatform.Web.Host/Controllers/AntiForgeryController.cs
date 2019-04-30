using Microsoft.AspNetCore.Antiforgery;
using IHuangPu.StrategyPlatform.Controllers;

namespace IHuangPu.StrategyPlatform.Web.Host.Controllers
{
    public class AntiForgeryController : StrategyPlatformControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
