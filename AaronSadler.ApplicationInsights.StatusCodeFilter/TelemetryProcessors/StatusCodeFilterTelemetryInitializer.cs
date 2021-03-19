using Microsoft.ApplicationInsights.Channel;
using Microsoft.ApplicationInsights.DataContracts;
using Microsoft.ApplicationInsights.Extensibility;

namespace AaronSadler.ApplicationInsights.StatusCodeFilter.TelemetryProcessors
{
    public class StatusCodeFilterTelemetryInitializer : ITelemetryInitializer
    {
        private ITelemetryProcessor Next { get; set; }
        public void Initialize(ITelemetry telemetry)
        {
            var request = telemetry as RequestTelemetry;
            var statusCodesToFilter = AppSettingsManager.GetStatusCodes();
            foreach (var statusCodeToFilter in statusCodesToFilter)
            {
                if (request != null && request.ResponseCode == statusCodeToFilter)
                {
                    request.Success = true;
                }
            }
        }
    }
}
