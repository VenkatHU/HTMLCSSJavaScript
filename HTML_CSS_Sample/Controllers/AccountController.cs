using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using DotNetOpenAuth.AspNet;
using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;
//using HTML_CSS_Sample.Filters;
using HTML_CSS_Sample.Models;

namespace HTML_CSS_Sample.Controllers
{
    [Authorize]
    //[InitializeSimpleMembership]
    public class AccountController : Controller
    {
        private SampleEntities1 db = new SampleEntities1();
        //
        // GET: /Account/Login

        [AllowAnonymous]
        public ActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        //
        // POST: /Account/Login

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LogIn model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                LogIn Validlogin = new LogIn();
                Validlogin = db.LogIns.Where(a => a.UserName.Equals(model.UserName) && a.Password.Equals(model.Password)).FirstOrDefault();
                if (Validlogin != null)
                {
                    Session["UserName"] = Validlogin.UserName.ToString();

                    if (ReturnUrl != null || ReturnUrl != "/")
                    {
                        return Redirect(ReturnUrl);
                    }
                    return RedirectToAction("Index", "Home");
                }

            }

            ModelState.AddModelError("", "The user name or password provided is incorrect.");
            return View(model);
        }
    }
}
