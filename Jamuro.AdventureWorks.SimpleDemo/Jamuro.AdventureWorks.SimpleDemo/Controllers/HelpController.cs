using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;
using Jamuro.AdventureWorks.Services.Workers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class HelpController : Controller
    {
        public ActionResult EntityFramework()
        {
            EntityFrameworkViewModel entityFrameworkViewModel = new EntityFrameworkViewModel();
            return View(entityFrameworkViewModel);
        }

        public ActionResult Linq()
        {
            LinqViewModel linqViewModel = new LinqViewModel();
            return View(linqViewModel);
        }
    }
}