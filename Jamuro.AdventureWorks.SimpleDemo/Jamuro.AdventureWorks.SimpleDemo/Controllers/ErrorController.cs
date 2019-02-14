using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;
using Jamuro.AdventureWorks.SimpleDemo.Helpers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    [AllowAnonymous]
    public class ErrorController : BaseController
    {
        public ActionResult Error()
        {
            ErrorViewModel model = new ErrorViewModel{};
            return View(model);
        }

        public ActionResult NotFound(string url)
        {
            NotFoundViewModel model = new NotFoundViewModel
            {
                Url = url
            };

            return View(model);
        }

        public ActionResult InternalError(string url)
        {
            InternalErrorViewModel model = new InternalErrorViewModel
            {
                Url = url
            };

            return View(model);
        }

        public ActionResult GetErrorImage(string key)
        {
            
            var dir = Server.MapPath("/Content/Images");
            var path = System.IO.Path.Combine(dir, MemoryCacheManager.GetAppSettings(key ?? "jamuro:DefaultErrorImage"));
            return base.File(path, "image/jpeg");
        }
    }
}