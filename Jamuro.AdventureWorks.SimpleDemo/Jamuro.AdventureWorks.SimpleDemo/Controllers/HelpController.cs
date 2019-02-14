using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;
using Jamuro.AdventureWorks.Services.Workers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class HelpController : BaseController
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

        public ActionResult SQLMonitorization()
        {
            return View();
        }

        public ActionResult SQLIndexes()
        {
            return View();
        }

        public ActionResult SQLResourceOptimization()
        {
            return View();
        }

        public ActionResult SQLQueryOptimization()
        {
            return View();
        }

        
    }
}