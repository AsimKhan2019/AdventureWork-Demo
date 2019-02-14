using System.Configuration;
using System.Runtime.Caching;
using System.Threading;
using System.Web.Configuration;

namespace Jamuro.AdventureWorks.SimpleDemo.Helpers
{
    public static class MemoryCacheManager
    {
        public static string GetAppSettings(string appSettingName)
        {
            return GetAppSettings(string.Empty, appSettingName);
        }

        public static string GetAppSettings(string appSettingIdentifier, string appSettingName)
        {
            string key = $"{appSettingIdentifier}{appSettingName}";
            object result = MemoryCache.Default.Get(key, null);
            string appSettingValue = string.Empty;

            if (result == null)
            {
                appSettingValue = ConfigurationManager.AppSettings[appSettingName];
                if (!string.IsNullOrWhiteSpace(appSettingValue))
                {
                    MemoryCache.Default.Set(key, appSettingValue, new CacheItemPolicy());
                }
            }
            else
            {
                appSettingValue = result.ToString();
            }

            return string.IsNullOrWhiteSpace(appSettingValue) ? string.Empty : appSettingValue;
        }

        public static string GetDefaultUICulture()
        {
            string defaultUICulture = string.Empty;
            string key = $"DefaultUICulture";
            object result = MemoryCache.Default.Get(key, null);
            if (result == null)
            {
                Configuration config = WebConfigurationManager.OpenWebConfiguration("/");
                GlobalizationSection section = (GlobalizationSection)config.GetSection("system.web/globalization");
                defaultUICulture = section.UICulture;
                MemoryCache.Default.Set(key, defaultUICulture, new CacheItemPolicy());
            }
            else
            {
                defaultUICulture = MemoryCache.Default.Get(key).ToString();
            }
            return defaultUICulture;
        }
    }
}