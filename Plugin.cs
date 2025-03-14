using BepInEx;
using acidphantasm_moretagcolours.Patches;
using acidphantasm_moretagcolours.Config;

namespace acidphantasm_moretagcolours
{
    [BepInPlugin("com.acidphantasm.moretagcolours", "acidphantasm-MoreTagColours", "1.3.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            Logger.LogInfo("[MoreTagColours] loading...");

            MoreTagColoursConfig.InitConfig(Config);

            new GetColorPatch().Enable();
            new TagColorsPanelPatch().Enable();
            new ResizeWindowPatch().Enable();

            Logger.LogInfo("[MoreTagColours] loaded!");
        }
    }
}
