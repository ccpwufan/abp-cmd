using AbpCMD.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpCMD.Permissions;

public class AbpCMDPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpCMDPermissions.GroupName);

        var booksPermission = myGroup.AddPermission(AbpCMDPermissions.Books.Default, L("Permission:Books"));
        booksPermission.AddChild(AbpCMDPermissions.Books.Create, L("Permission:Books.Create"));
        booksPermission.AddChild(AbpCMDPermissions.Books.Edit, L("Permission:Books.Edit"));
        booksPermission.AddChild(AbpCMDPermissions.Books.Delete, L("Permission:Books.Delete"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpCMDPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpCMDResource>(name);
    }
}
