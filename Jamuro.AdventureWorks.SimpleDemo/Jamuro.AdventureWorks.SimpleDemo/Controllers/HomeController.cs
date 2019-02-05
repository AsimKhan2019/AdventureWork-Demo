using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Jamuro.AdventureWorks.Services.Workers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About Page";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Page";
            return View();
        }
    }
}