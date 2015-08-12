using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleBlog.ViewModels;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public object FormsAuthentivcation { get; private set; }

        public ActionResult Login()
       {
            return View();
       }

       [HttpPost]
       public ActionResult Login(AuthLogin form, string returnUrl)
       {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            FormsAuthentication.SetAuthCookie(form.username, true);
            
            if(!string.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return Redirect("home");
       }

       public ActionResult Logout()
       {
            FormsAuthentication.SignOut();
            return RedirectToRoute("home");
       } 
    }
}