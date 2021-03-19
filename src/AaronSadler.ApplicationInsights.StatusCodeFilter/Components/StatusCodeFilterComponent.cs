using AaronSadler.ApplicationInsights.StatusCodeFilter.TelemetryProcessors;
using Microsoft.ApplicationInsights.Extensibility;
using Umbraco.Core.Composing;

namespace AaronSadler.ApplicationInsights.StatusCodeFilter.Components
{
    public class StatusCodeFilterComponent : IComponent
    {
        public void Initialize()
        {
            TelemetryConfiguration.Active.TelemetryInitializers.Add(new StatusCodeFilterTelemetryInitializer());
        }

        public void Terminate()
        { }
    }
}
