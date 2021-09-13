using Volo.Abp.Modularity;

namespace Akd.CarManager
{
    [DependsOn(
        typeof(CarManagerApplicationModule),
        typeof(CarManagerDomainTestModule)
        )]
    public class CarManagerApplicationTestModule : AbpModule
    {

    }
}