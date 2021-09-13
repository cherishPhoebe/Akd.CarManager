using Akd.CarManager.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Akd.CarManager.Permissions
{
    public class CarManagerPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(CarManagerPermissions.GroupName);
            //Define your own permissions here. Example:
            //myGroup.AddPermission(CarManagerPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<CarManagerResource>(name);
        }
    }
}
