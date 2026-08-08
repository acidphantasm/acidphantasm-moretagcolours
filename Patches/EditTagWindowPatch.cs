using SPT.Reflection.Patching;
using HarmonyLib;
using System.Reflection;
using EFT.UI;
using UnityEngine;
using Comfort.Common;
using MoreTagColours.Config;

namespace MoreTagColours.Patches
{
    internal class GetColorPatch : ModulePatch
    {

        public static readonly Color[] Color0 =
        [
            MoreTagColoursConfig.Colour01.Value,
            MoreTagColoursConfig.Colour02.Value,
            MoreTagColoursConfig.Colour03.Value,
            MoreTagColoursConfig.Colour04.Value,
            MoreTagColoursConfig.Colour05.Value,
            MoreTagColoursConfig.Colour06.Value,
            MoreTagColoursConfig.Colour07.Value,
            MoreTagColoursConfig.Colour08.Value,
            MoreTagColoursConfig.Colour09.Value,

            MoreTagColoursConfig.Colour10.Value,
            MoreTagColoursConfig.Colour11.Value,
            MoreTagColoursConfig.Colour12.Value,
            MoreTagColoursConfig.Colour13.Value,
            MoreTagColoursConfig.Colour14.Value,
            MoreTagColoursConfig.Colour15.Value,
            MoreTagColoursConfig.Colour16.Value,
            MoreTagColoursConfig.Colour17.Value,
            MoreTagColoursConfig.Colour18.Value,

            new(0.1f, 0.1f, 0.1f),
            new(0.2f, 0.2f, 0.2f),
            new(0.3f, 0.3f, 0.3f),
            new(0.4f, 0.4f, 0.4f),
            new(0.5f, 0.5f, 0.5f),
            new(0.6f, 0.6f, 0.6f),
            new(0.7f, 0.7f, 0.7f),
            new(0.8f, 0.8f, 0.8f),
            new(0.9f, 0.9f, 0.9f)
        ];

        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(EditTagWindow), nameof(EditTagWindow.GetColor));
        }

        [PatchPrefix]
        public static bool Prefix(ref Color __result, int colorIndex)
        {
            if (colorIndex >= Color0.Length)
            {
                colorIndex = 0;
            }
            __result = Color0[colorIndex];
            return false;
        }
    }
    internal class ResizeWindowPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            return AccessTools.Method(typeof(EditTagWindow), nameof(EditTagWindow.Show));
        }

        [PatchPostfix]
        public static void Postfix(EditTagWindow __instance)
        {
            __instance.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 260);
        }
    }
}
