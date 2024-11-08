
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace AppForSpiff.Components
{
    public class CookieEvents : CookieAuthenticationEvents
    {
        public override Task RedirectToLogin(RedirectContext<CookieAuthenticationOptions> context)
        {
            context.RedirectUri = "/Account/Login";
            return base.RedirectToLogin(context);
        }
    }
}
