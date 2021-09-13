using System;
using System.Collections.Generic;
using System.Text;
using Akd.CarManager.Localization;
using Volo.Abp.Application.Services;

namespace Akd.CarManager
{
    /* Inherit your application services from this class.
     */
    public abstract class CarManagerAppService : ApplicationService
    {
        protected CarManagerAppService()
        {
            LocalizationResource = typeof(CarManagerResource);
        }
    }
}
