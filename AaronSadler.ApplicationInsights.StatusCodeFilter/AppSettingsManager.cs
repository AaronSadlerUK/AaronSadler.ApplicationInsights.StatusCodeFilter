using System.Collections.Generic;
using System.Configuration;

namespace AaronSadler.ApplicationInsights.StatusCodeFilter
{
    internal static class AppSettingsManager
    {
        public static IEnumerable<string> GetStatusCodes()
        {
            var statusCodeList = new List<string>{"404"};
            var statusCodeSetting = ConfigurationManager.AppSettings["ApplicationInsights.StatusCodeFilter.StatusCodes"];
            if (!string.IsNullOrEmpty(statusCodeSetting) || !string.IsNullOrWhiteSpace(statusCodeSetting))
            {
                statusCodeList.AddRange(statusCodeSetting.Split(','));
            }

            return statusCodeList.ToArray();
        }
    }
}
