using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Abcd.Web
{
    [Dependency(ReplaceServices = true)]
    public class AbcdBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Abcd";
    }
}
