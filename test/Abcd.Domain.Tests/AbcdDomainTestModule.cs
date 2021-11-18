using Abcd.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Abcd
{
    [DependsOn(
        typeof(AbcdEntityFrameworkCoreTestModule)
        )]
    public class AbcdDomainTestModule : AbpModule
    {

    }
}