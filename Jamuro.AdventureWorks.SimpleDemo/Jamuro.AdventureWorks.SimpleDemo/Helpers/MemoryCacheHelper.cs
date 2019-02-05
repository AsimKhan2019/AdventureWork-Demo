using System.Configuration;
using System.Runtime.Caching;

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

    }
}