using System;
using System.Collections.Generic;
using System.Configuration;

namespace AaronSadler.ApplicationInsights.StatusCodeFilter
{
    internal static class AppSettingsManager
    {
        public static bool GetEnabled()
        {
            return ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.Enabled"] != null
                   && Convert.ToBoolean(ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.Enabled"]);
        }
        public static bool GetExcludeFromApplicationInsights()
        {
            return ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.Exclude"] != null
                   && Convert.ToBoolean(ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.Exclude"]);
        }
        public static IEnumerable<string> GetStatusCodes()
        {
            var statusCodeList = new List<string>{"404"};
            var statusCodeSetting = ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.StatusCodes"];
            if (!string.IsNullOrWhiteSpace(statusCodeSetting))
            {
                statusCodeList.Clear();
                statusCodeList.AddRange(statusCodeSetting.Split(','));
            }

            return statusCodeList.ToArray();
        }
    }
}
