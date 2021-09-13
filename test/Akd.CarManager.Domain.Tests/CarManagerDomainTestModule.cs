using Akd.CarManager.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Akd.CarManager
{
    [DependsOn(
        typeof(CarManagerEntityFrameworkCoreTestModule)
        )]
    public class CarManagerDomainTestModule : AbpModule
    {

    }
}