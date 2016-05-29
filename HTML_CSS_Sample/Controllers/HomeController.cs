using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTML_CSS_Sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

       
        public ActionResult Oracle()
        {
           return View();
        }

        public ActionResult Access()
        {
            return View();
        }

        public ActionResult Clanguage()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult css()
        {
            return View();
        }
        public ActionResult Excel()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult HTML()
        {
            return View();
        }
        public ActionResult SiteMap()
        {
            return View();
        }
        public ActionResult SQL()
        {
            return View();
        }
        public ActionResult SQLServer()
        {
            return View();
        }
        public ActionResult Word()
        {
            return View();
        }

    }
}
