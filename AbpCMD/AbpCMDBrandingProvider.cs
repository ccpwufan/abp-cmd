using Microsoft.Extensions.Localization;
using AbpCMD.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpCMD;

[Dependency(ReplaceServices = true)]
public class AbpCMDBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpCMDResource> _localizer;

    public AbpCMDBrandingProvider(IStringLocalizer<AbpCMDResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
