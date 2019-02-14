using System.Threading;
using System.Configuration;
using System.Web.Configuration;

namespace Jamuro.AdventureWorks.SimpleDemo.Helpers
{
    public class GlobalHelper
    {
        protected GlobalHelper()
        {

        }

        public static string CurrentUICulture()
        {
            return Thread.CurrentThread.CurrentUICulture.Name;
        }
        public static string DefaultUICulture()
        {
            return MemoryCacheManager.GetDefaultUICulture();
        }
    }
}