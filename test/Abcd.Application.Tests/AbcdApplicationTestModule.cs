using Volo.Abp.Modularity;

namespace Abcd
{
    [DependsOn(
        typeof(AbcdApplicationModule),
        typeof(AbcdDomainTestModule)
        )]
    public class AbcdApplicationTestModule : AbpModule
    {

    }
}