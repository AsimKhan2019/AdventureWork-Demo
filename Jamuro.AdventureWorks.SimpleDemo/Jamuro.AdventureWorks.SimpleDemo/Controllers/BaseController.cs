using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.Resources;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class BaseController : Controller
    {
        private log4net.ILog logger;

        public ActionResult TestException()
        {
            throw new Exception(ErrorMessages.Error_SomethingWasWrong);
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            /* Log exception */
            logger = log4net.LogManager.GetLogger(typeof(BaseController));
            logger.Error(filterContext.Exception.Message, filterContext.Exception);

            /* Handle exception */
            if (filterContext.HttpContext.Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            {
                /* Return JSON error message */
                filterContext.ExceptionHandled = true;
                filterContext.Result = new JsonResult
                {
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                    Data = new { error = true, message = ErrorMessages.Error_SomethingWasWrong }
                };
            }
            else
            {
                /* Redirect to error common page */
                filterContext.ExceptionHandled = true;
                filterContext.Result = this.RedirectToAction("Error", "Error");
            }

            base.OnException(filterContext);
        }
    }
}