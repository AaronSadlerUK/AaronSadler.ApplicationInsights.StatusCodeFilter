using AaronSadler.ApplicationInsights.StatusCodeFilter.Components;
using Umbraco.Core.Composing;

namespace AaronSadler.ApplicationInsights.StatusCodeFilter.Composers
{
    public class RegisterStatusCodeFilterComposer : ComponentComposer<StatusCodeFilterComponent>, IUserComposer
    {
        public override void Compose(Composition composition)
        {
            base.Compose(composition);
        }
    }
}
