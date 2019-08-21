using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Mvc;

namespace Toll.portal.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return Challenge(new AuthenticationProperties() { RedirectUri="Home/Index" }, OpenIdConnectDefaults.AuthenticationScheme);
        }
    }
}