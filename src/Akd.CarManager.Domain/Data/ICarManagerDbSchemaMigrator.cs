using System.Threading.Tasks;

namespace Akd.CarManager.Data
{
    public interface ICarManagerDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
