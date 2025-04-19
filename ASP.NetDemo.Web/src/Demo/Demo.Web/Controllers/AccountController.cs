using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Web.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]

        public IActionResult Login()
        {
            return View();
        }
        [Authorize]
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
