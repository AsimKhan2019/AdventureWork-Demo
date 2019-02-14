using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Jamuro.AdventureWorks.Resources;
using Jamuro.AdventureWorks.SimpleDemo.Helpers;

namespace Jamuro.AdventureWorks.SimpleDemo.Controllers
{
    public class BaseController : Controller
    {
        private log4net.ILog logger;

        private static string m_cookieMultiLanguageName = MemoryCacheManager.GetAppSettings("jamuro:MultiLanguageCookieName");

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

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string cultureOnCookie = GetCultureOnCookie(filterContext.HttpContext.Request);
            string cultureOnURL = filterContext.RouteData.Values.ContainsKey("lang") ? filterContext.RouteData.Values["lang"].ToString() : GlobalHelper.DefaultUICulture();
            string culture = (cultureOnCookie == string.Empty) ? (filterContext.RouteData.Values["lang"].ToString()) : cultureOnCookie;
            if (cultureOnURL != culture)
            {
                filterContext.HttpContext.Response.RedirectToRoute("LocalizedDefault", new { lang = culture, controller = filterContext.RouteData.Values["controller"], action = filterContext.RouteData.Values["action"] });
                return;
            }
            SetCurrentUICultureOnThread(culture);
            if (culture != MultiLanguageViewEngine.CurrentUICulture())
            {
                (ViewEngines.Engines[0] as MultiLanguageViewEngine).SetCurrentUICulture(culture);
            }
            base.OnActionExecuting(filterContext);
        }

        private static void SetCurrentUICultureOnThread(string lang)
        {
            if (string.IsNullOrEmpty(lang))
                lang = GlobalHelper.DefaultUICulture();
            var cultureInfo = new System.Globalization.CultureInfo(lang);
            System.Threading.Thread.CurrentThread.CurrentUICulture = cultureInfo;
            System.Threading.Thread.CurrentThread.CurrentCulture = cultureInfo;
        }

        public static String GetCultureOnCookie(HttpRequestBase request)
        {
            var cookie = request.Cookies[m_cookieMultiLanguageName];
            string culture = string.Empty;
            if (cookie != null)
            {
                culture = cookie.Value;
            }
            return culture;
        }
    }
}