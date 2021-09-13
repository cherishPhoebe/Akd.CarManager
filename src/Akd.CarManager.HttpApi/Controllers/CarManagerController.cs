using Akd.CarManager.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Akd.CarManager.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CarManagerController : AbpController
    {
        protected CarManagerController()
        {
            LocalizationResource = typeof(CarManagerResource);
        }
    }
}