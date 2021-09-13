using Akd.CarManager.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Akd.CarManager.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CarManagerEntityFrameworkCoreModule),
        typeof(CarManagerApplicationContractsModule)
        )]
    public class CarManagerDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
