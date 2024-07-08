using SPT.Reflection.Patching;
using HarmonyLib;
using System.Reflection;
using EFT.UI;
using UnityEngine;

namespace acidphantasm_moretagcolours.Patches
{
    internal class GetColorPatch : ModulePatch
    {

        public static readonly Color[] color_0 = new Color[]
        {
            new Color(1f, 0f, 0f),
            new Color(1f, 0.5f, 0f),
            new Color(1f, 1f, 0f),
            new Color(0.224f, 1f, 0f),
            new Color(0f, 1f, 0.859f),
            new Color(0f, 0.529f, 1f),
            new Color(0.102f, 0f, 1f),
            new Color(0.463f, 0f, 1f),
            new Color(1f, 0f, 0.549f),

            new Color(0.349f, 0.122f, 0.122f),
            new Color(0.18f, 0.106f, 0.024f),
            new Color(0.349f, 0.267f, 0.122f),
            new Color(0.106f, 0.329f, 0.067f),
            new Color(0.122f, 0.271f, 0.247f),
            new Color(0.071f, 0.22f, 0.349f),
            new Color(0.067f, 0.047f, 0.251f),
            new Color(0.165f, 0.051f, 0.302f),
            new Color(0.278f, 0.047f, 0.176f),
        };

        protected override MethodBase GetTargetMethod()
        {
            //methods are patched by targeting both their class name and the name of the method itself.
            //the example in this patch is the Jump() method in the Player class
            return AccessTools.Method(typeof(EditTagWindow), nameof(EditTagWindow.GetColor));
        }

        [PatchPrefix]
        public static bool Prefix(ref Color __result, int colorIndex)
        {
            if (colorIndex >= GetColorPatch.color_0.Length)
            {
                colorIndex = 0;
            }
            __result = GetColorPatch.color_0[colorIndex];
            return false;
        }
    }
    internal class ResizeWindowPatch : ModulePatch
    {
        protected override MethodBase GetTargetMethod()
        {
            //methods are patched by targeting both their class name and the name of the method itself.
            //the example in this patch is the Jump() method in the Player class
            return typeof(EditTagWindow).GetMethod("Show",  BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
        }


        [PatchPostfix]
        public static void Postfix()
        {
            GameObject tagWindow = GameObject.Find("EditTagWindowTemplate(Clone)");

            tagWindow.GetComponent<RectTransform>().sizeDelta = new Vector2(450, 230);
        }
    }
}
