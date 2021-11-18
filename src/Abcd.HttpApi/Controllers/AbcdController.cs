using Abcd.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Abcd.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbcdController : AbpController
    {
        protected AbcdController()
        {
            LocalizationResource = typeof(AbcdResource);
        }
    }
}