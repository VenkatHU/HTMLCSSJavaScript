using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTML_CSS_Sample.Models;

namespace HTML_CSS_Sample.Controllers
{
    public class SampleLoginController : Controller
    {
        private SampleEntities1 db = new SampleEntities1();
        
        // GET: /SampleLogin/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /SampleLogin/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogIn login, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                db.LogIns.Add(login);
                db.SaveChanges();
                Session["UserName"] = login.UserName;

                return RedirectToAction("Index", "Home");
            }

            return View(login);
        }

        
        public ActionResult LogOffUser()
        {
            Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}