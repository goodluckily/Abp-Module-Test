using Volo.Abp.Settings;

namespace Abcd.Settings
{
    public class AbcdSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbcdSettings.MySetting1));
        }
    }
}
