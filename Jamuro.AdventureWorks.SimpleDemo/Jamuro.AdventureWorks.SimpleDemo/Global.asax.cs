using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Jamuro.AdventureWorks.SimpleDemo.Controllers;
using Jamuro.AdventureWorks.SimpleDemo.ViewModels;

namespace Jamuro.AdventureWorks.SimpleDemo
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            Services.UnityBootstrapper.Init();
            UnityConfig.RegisterComponents();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles); 
        }

        protected void Application_EndRequest()
        {
            if (Context.Response.StatusCode == 404)
            {
                #region Page Not Found

                Response.Clear();
                RouteData rd = new RouteData();
                rd.Values["controller"] = "Error";
                rd.Values["action"] = "NotFound";
                rd.Values["url"] = Context.Request.Url;
                IController c = new ErrorController();
                c.Execute(new RequestContext(new HttpContextWrapper(Context), rd));

                #endregion
            }
            else if (Context.Response.StatusCode == 500)
            {
                #region Internal Server Error

                Response.Clear();
                RouteData rd = new RouteData();
                rd.Values["controller"] = "Error";
                rd.Values["action"] = "InternalError";
                rd.Values["url"] = Context.Request.Url;
                IController c = new ErrorController();
                c.Execute(new RequestContext(new HttpContextWrapper(Context), rd));

                #endregion
            }
        }

        protected void Application_Error()
        {
            Exception ex = Server.GetLastError();
            log4net.ILog logger = log4net.LogManager.GetLogger("ApplicationError");
            logger.Error(ex.Message, ex);
        }
    }
}
