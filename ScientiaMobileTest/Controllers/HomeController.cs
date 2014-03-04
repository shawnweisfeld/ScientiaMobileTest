using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ScientiaMobileTest.Util;

namespace ScientiaMobileTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var foo = System.Web.HttpContext.Current.Request.DeviceInfo();

            return View(foo);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}