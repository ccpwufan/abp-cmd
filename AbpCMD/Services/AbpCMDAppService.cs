using Volo.Abp.Application.Services;
using AbpCMD.Localization;

namespace AbpCMD.Services;

/* Inherit your application services from this class. */
public abstract class AbpCMDAppService : ApplicationService
{
    protected AbpCMDAppService()
    {
        LocalizationResource = typeof(AbpCMDResource);
    }
}