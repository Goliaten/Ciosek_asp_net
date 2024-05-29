using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Ciosek_asp_net.Controllers
{
    public class AccountController : Controller
    {
        public AccountController(UserManager<AppUser> userMgr, SignInManager<AppUser> signInMgr)
        {
            UserMgr = userMgr;
            SignInMgr = signInMgr;
        }

        private UserManager<AppUser> UserMgr { get; set; }
        private SignInManager<AppUser> SignInMgr { get; set; }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Register()
        {
            try
            {
                ViewBag.message = "Użytkownik jest już zarejestrowany.";

                AppUser user = await UserMgr.FindByNameAsync("TestUser");

                if (user == null)
                {
                    user = new AppUser()
                    {
                        UserName = "testuser",
                        Email = "test@wp.pl",
                        FirstName = "Grzegorz",
                        LastName = "Brzęczyszczykiewicz",
                    };
                    IdentityResult result = await UserMgr.CreateAsync(user, "test");
                    ViewBag.message = "Użytkownik stworzony";
                }
            }
            catch (Exception e)
            {
                ViewBag.message = e.Message;
            }

            return View();
        }

        public async Task<IActionResult> Login()
        {
            var result = await SignInMgr.PasswordSignInAsync("testuser", "test", false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result = "Status logowania" + result.ToString();
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
