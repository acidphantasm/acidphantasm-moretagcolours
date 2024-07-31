using EFT.UI;
using HarmonyLib;
using SPT.Reflection.Patching;
using System.Reflection;
using UnityEngine;

namespace acidphantasm_moretagcolours.Patches
{
    internal class TagColorsPanelPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(TagColorsPanel), nameof(TagColorsPanel.Show));
        }

        [PatchPrefix]
        public static void Prefix(ref Color[] colors)
        {
            colors = GetColorPatch.color_0;
        }
    }
}
