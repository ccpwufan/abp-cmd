using AbpCMD.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpCMD;

public abstract class AbpCMDComponentBase : AbpComponentBase
{
    protected AbpCMDComponentBase()
    {
        LocalizationResource = typeof(AbpCMDResource);
    }
}
