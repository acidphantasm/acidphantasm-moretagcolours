using BepInEx;
using MoreTagColours.Patches;
using MoreTagColours.Config;

namespace MoreTagColours
{
    [BepInPlugin("com.acidphantasm.moretagcolours", "acidphantasm-moretagcolours", "1.5.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            MoreTagColoursConfig.InitConfig(Config);

            new GetColorPatch().Enable();
            new TagColorsPanelPatch().Enable();
            new ResizeWindowPatch().Enable();
        }
    }
}
