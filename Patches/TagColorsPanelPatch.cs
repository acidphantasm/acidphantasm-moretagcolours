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
            //methods are patched by targeting both their class name and the name of the method itself.
            //the example in this patch is the Jump() method in the Player class
            return AccessTools.Method(typeof(TagColorsPanel), nameof(TagColorsPanel.Show));
        }

        [PatchPrefix]
        public static void Prefix(ref Color[] colors)
        {
            colors = GetColorPatch.color_0;
        }
    }
}
