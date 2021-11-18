using Abcd.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Abcd.Permissions
{
    public class AbcdPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbcdPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbcdPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbcdResource>(name);
        }
    }
}
