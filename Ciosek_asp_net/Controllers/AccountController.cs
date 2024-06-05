using Ciosek_asp_net.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

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

        /*
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
        }*/
        
        [HttpGet]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(DodawanieUżytkownika model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = new AppUser()
            {
                UserName = model.userName,
                Email = model.email,
                FirstName = model.firstName,
                LastName = model.lastName,
            };
            IdentityResult result = await UserMgr.CreateAsync(user, model.confirmedPassword);


            var errorList = result.Errors.ToList();

            ViewBag.message = string.Join(", <br>", errorList.Select(e => e.Description));
            if (!result.Succeeded)
            {
                return View();
            }

            await SignInMgr.SignInAsync(user, false);
            return RedirectToAction("Index", "Home");


        }

        [HttpGet]
        public async Task<IActionResult> Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(DodawanieUżytkownika model)
        {
            var result = await SignInMgr.PasswordSignInAsync(model.userName, model.password, false, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.result = "Status logowania " + result.ToString();
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
