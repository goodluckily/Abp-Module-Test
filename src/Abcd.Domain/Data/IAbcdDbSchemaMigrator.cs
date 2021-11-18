using System.Threading.Tasks;

namespace Abcd.Data
{
    public interface IAbcdDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
