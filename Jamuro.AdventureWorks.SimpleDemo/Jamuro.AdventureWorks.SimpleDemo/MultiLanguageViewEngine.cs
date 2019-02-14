using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Collections;
using Jamuro.AdventureWorks.SimpleDemo.Helpers;

namespace Jamuro.AdventureWorks.SimpleDemo
{
    public class MultiLanguageViewEngine : RazorViewEngine
    {
        private static string m_CurrentUICulture = GlobalHelper.CurrentUICulture();

        public MultiLanguageViewEngine() : this(GlobalHelper.CurrentUICulture())
        {
        }

        public MultiLanguageViewEngine(string language)
        {
            SetCurrentUICulture(language);
        }

        public void SetCurrentUICulture(string language)
        {
            ViewLocationFormats = new string[]
            {
                "~/Views/{1}/" + language + "/{0}.cshtml",
                "~/Views/Shared/" + language + "/{0}.cshtml",
                "~/Views/{1}/{0}.cshtml",
                "~/Views/Shared/{0}.cshtml"
            };
        }

        public static string CurrentUICulture()
        {
            return m_CurrentUICulture;
        }
    }
}