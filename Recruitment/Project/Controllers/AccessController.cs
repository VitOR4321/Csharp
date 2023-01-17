using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Project.Models;
using Project.Data;
using Microsoft.EntityFrameworkCore;
using Project.Models.Domain;

namespace Project.Controllers
{
    public class AccessController : Controller
    {
        private readonly Context context;

        public AccessController(Context context)
        {
            this.context = context;
        }

        public IActionResult Login()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Contact");
            }

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(Account modelLogin)
        {
            var contacts = await context.Contacts.ToListAsync();
            var access = new Account();

            if (contacts.Any())
            {
                foreach (var contact in contacts)
                {
                    access = new Account()
                    {
                        email = contact.email,
                        password = contact.password,
                    };

                    if (modelLogin.email == access.email && modelLogin.password == access.password)
                    {
                        List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.NameIdentifier, modelLogin.email),
                    new Claim("OtherProperties", "Expample Role")

                };

                        ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                            CookieAuthenticationDefaults.AuthenticationScheme);

                        AuthenticationProperties properties = new AuthenticationProperties()
                        {
                            AllowRefresh = true,
                            IsPersistent = modelLogin.keepLoggedIn,
                        };

                        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                            new ClaimsPrincipal(claimsIdentity), properties);

                        return RedirectToAction("Index", "Contact");
                    }
                }
           
            }

            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
