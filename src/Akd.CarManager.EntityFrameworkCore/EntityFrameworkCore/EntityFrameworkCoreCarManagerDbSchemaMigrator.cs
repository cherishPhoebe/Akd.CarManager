using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Akd.CarManager.Data;
using Volo.Abp.DependencyInjection;

namespace Akd.CarManager.EntityFrameworkCore
{
    public class EntityFrameworkCoreCarManagerDbSchemaMigrator
        : ICarManagerDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreCarManagerDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the CarManagerDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<CarManagerDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}
