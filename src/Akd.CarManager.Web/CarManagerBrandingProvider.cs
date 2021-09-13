using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Akd.CarManager.Web
{
    [Dependency(ReplaceServices = true)]
    public class CarManagerBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CarManager";
    }
}
