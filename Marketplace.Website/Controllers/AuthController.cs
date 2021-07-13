using System.Web.Mvc;
using Marketplace.Website.Models;
using System.Web;
using System.Security.Claims;
using Microsoft.Owin;
using Microsoft.Owin.Security;

namespace Marketplace.Website.Controllers
{
    [AllowAnonymous]
    public class AuthController : BaseController
    {
        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new LogInModel
            {
                ReturnUrl = @returnUrl
            };            
            return View(model);
        }

        
        [HttpPost]
        public ActionResult LogIn(LogInModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            //TODO:
            if (model.Email == "admin@admin.com" && model.Password == "admin")
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, "admin"),
                    new Claim(ClaimTypes.Email, "admin@admin.com"),
                    new Claim(ClaimTypes.Country, "Argentina"),
                };

                var identity = new ClaimsIdentity(claims, "ApplicationCookie");

                IOwinContext context = Request.GetOwinContext();
                IAuthenticationManager authManager = context.Authentication;

                authManager.SignIn(identity);
                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            ModelState.AddModelError("", "El email o la contraseña no son válidos.");
            return View();
        }

        public ActionResult LogOut()
        {
            var context = Request.GetOwinContext();
            var authManager = context.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Index", "Home");
        }
    }
}