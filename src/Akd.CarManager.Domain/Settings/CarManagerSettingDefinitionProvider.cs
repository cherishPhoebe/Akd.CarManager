using Volo.Abp.Settings;

namespace Akd.CarManager.Settings
{
    public class CarManagerSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CarManagerSettings.MySetting1));
        }
    }
}
