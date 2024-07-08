using acidphantasm_moretagcolours.Patches;
using BepInEx;
using BepInEx.Logging;
using Comfort.Common;
using EFT.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace acidphantasm_moretagcolours
{
    [BepInPlugin("com.acidphantasm.moretagcolours", "acidphantasm-MoreTagColours", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        public static ManualLogSource LogSource;
        private void Awake()
        {
            LogSource = Logger;
            LogSource.LogInfo("MoreTagColours loaded!");

            new GetColorPatch().Enable();
            new TagColorsPanelPatch().Enable();
            new ResizeWindowPatch().Enable();
        }
    }
}
