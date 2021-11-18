using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Abcd.Data
{
    /* This is used if database provider does't define
     * IAbcdDbSchemaMigrator implementation.
     */
    public class NullAbcdDbSchemaMigrator : IAbcdDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}