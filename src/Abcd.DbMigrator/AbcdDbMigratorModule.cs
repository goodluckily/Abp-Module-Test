using Abcd.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace Abcd.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbcdEntityFrameworkCoreModule),
        typeof(AbcdApplicationContractsModule)
        )]
    public class AbcdDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
