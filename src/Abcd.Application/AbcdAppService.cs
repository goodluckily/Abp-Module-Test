using System;
using System.Collections.Generic;
using System.Text;
using Abcd.Localization;
using Volo.Abp.Application.Services;

namespace Abcd
{
    /* Inherit your application services from this class.
     */
    public abstract class AbcdAppService : ApplicationService
    {
        protected AbcdAppService()
        {
            LocalizationResource = typeof(AbcdResource);
        }
    }
}
