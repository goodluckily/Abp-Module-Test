using Abcd.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Abcd.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AbcdPageModel : AbpPageModel
    {
        protected AbcdPageModel()
        {
            LocalizationResourceType = typeof(AbcdResource);
        }
    }
}