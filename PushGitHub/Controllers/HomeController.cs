using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PushGitHub.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Where are you?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your page.";

            return View();
        }
    }
}