using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.Helpers;

namespace Jamuro.AdventureWorks.SimpleDemo
{
    public static class HtmlHelperExtensions
    {
        public static string GetPartialViewName(this HtmlHelper helper, string partialViewName, bool localizable = true)
        {
            if (localizable)
            {
                return string.Format("{0}/{1}", GlobalHelper.CurrentUICulture(), partialViewName);    
            }
            return string.Format("{0}",  partialViewName);
        }
    }
}