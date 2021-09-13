using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Akd.CarManager.Data
{
    /* This is used if database provider does't define
     * ICarManagerDbSchemaMigrator implementation.
     */
    public class NullCarManagerDbSchemaMigrator : ICarManagerDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}