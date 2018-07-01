using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string action)
        {
            if(action == "Login")
            {
                ViewBag.Title = "haha";
            }
            return View();
        }
    }
}
