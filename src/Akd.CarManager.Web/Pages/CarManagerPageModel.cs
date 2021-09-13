using Akd.CarManager.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Akd.CarManager.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class CarManagerPageModel : AbpPageModel
    {
        protected CarManagerPageModel()
        {
            LocalizationResourceType = typeof(CarManagerResource);
        }
    }
}