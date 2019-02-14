using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Web.Mvc;
using Jamuro.AdventureWorks.SimpleDemo.Helpers;

namespace Jamuro.AdventureWorks.SimpleDemo
{
    public static class UrlHelperExtensions
    {
        public static string GetImage(this UrlHelper helper, string imageFileName, bool localizable = true)
        {
            string strUrlPath, strFilePath = string.Empty;
            if (localizable)
            {
                /* Search result in current culture folder */
                strUrlPath = string.Format("/Content/Images/{0}/{1}", GlobalHelper.CurrentUICulture(), imageFileName);
                strFilePath = HttpContext.Current.Server.MapPath(strUrlPath);
                if (!File.Exists(strFilePath))
                {   
                    /* Search result in default culture folder */
                    strUrlPath = string.Format("/Content/Images/{0}/{1}", GlobalHelper.DefaultUICulture(), imageFileName);
                    if (File.Exists(strUrlPath))
                    {
                        /* Return result */
                        return strUrlPath;
                    }
                }
                else
                {
                    return strUrlPath;
                }                
            }

            /* Otherwise, search result in root directory folder */
            strUrlPath = string.Format("/Content/Images/{0}", imageFileName);
            strFilePath = HttpContext.Current.Server.MapPath(strUrlPath);
            if (File.Exists(strFilePath))
            {                   
                return strUrlPath;
            }

            return strUrlPath;
        }
    }
}