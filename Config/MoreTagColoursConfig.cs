using acidphantasm_moretagcolours.Patches;
using BepInEx.Configuration;
using System;
using UnityEngine;

namespace acidphantasm_moretagcolours.Config
{
    internal static class MoreTagColoursConfig
    {
        private const string ConfigSectionTitle = "Config";

        public static ConfigEntry<Color> Colour01;
        public static ConfigEntry<Color> Colour02;
        public static ConfigEntry<Color> Colour03;
        public static ConfigEntry<Color> Colour04;
        public static ConfigEntry<Color> Colour05;
        public static ConfigEntry<Color> Colour06;
        public static ConfigEntry<Color> Colour07;
        public static ConfigEntry<Color> Colour08;
        public static ConfigEntry<Color> Colour09;
        public static ConfigEntry<Color> Colour10;
        public static ConfigEntry<Color> Colour11;
        public static ConfigEntry<Color> Colour12;
        public static ConfigEntry<Color> Colour13;
        public static ConfigEntry<Color> Colour14;
        public static ConfigEntry<Color> Colour15;
        public static ConfigEntry<Color> Colour16;
        public static ConfigEntry<Color> Colour17;
        public static ConfigEntry<Color> Colour18;

        public static void InitConfig(ConfigFile config)
        {
            Colour01 = config.Bind(ConfigSectionTitle, "Colour 01", new Color(0.85f, 0f, 0f));
            Colour02 = config.Bind(ConfigSectionTitle, "Colour 02", new Color(0.85f, 0.5f, 0f));
            Colour03 = config.Bind(ConfigSectionTitle, "Colour 03", new Color(0.85f, 0.85f, 0f));
            Colour04 = config.Bind(ConfigSectionTitle, "Colour 04", new Color(0.224f, 0.85f, 0f));
            Colour05 = config.Bind(ConfigSectionTitle, "Colour 05", new Color(0f, 0.85f, 0.759f));
            Colour06 = config.Bind(ConfigSectionTitle, "Colour 06", new Color(0f, 0.529f, 0.85f));
            Colour07 = config.Bind(ConfigSectionTitle, "Colour 07", new Color(0.102f, 0f, 0.85f));
            Colour08 = config.Bind(ConfigSectionTitle, "Colour 08", new Color(0.463f, 0f, 0.85f));
            Colour09 = config.Bind(ConfigSectionTitle, "Colour 09", new Color(0.85f, 0f, 0.549f));
            Colour10 = config.Bind(ConfigSectionTitle, "Colour 10", new Color(0.349f, 0.122f, 0.122f));
            Colour11 = config.Bind(ConfigSectionTitle, "Colour 11", new Color(0.18f, 0.106f, 0.024f));
            Colour12 = config.Bind(ConfigSectionTitle, "Colour 12", new Color(0.349f, 0.267f, 0.122f));
            Colour13 = config.Bind(ConfigSectionTitle, "Colour 13", new Color(0.106f, 0.329f, 0.067f));
            Colour14 = config.Bind(ConfigSectionTitle, "Colour 14", new Color(0.122f, 0.271f, 0.247f));
            Colour15 = config.Bind(ConfigSectionTitle, "Colour 15", new Color(0.071f, 0.22f, 0.349f));
            Colour16 = config.Bind(ConfigSectionTitle, "Colour 16", new Color(0.067f, 0.047f, 0.251f));
            Colour17 = config.Bind(ConfigSectionTitle, "Colour 17", new Color(0.165f, 0.051f, 0.302f));
            Colour18 = config.Bind(ConfigSectionTitle, "Colour 18", new Color(0.278f, 0.047f, 0.176f));

            Colour01.SettingChanged += Colours_SettingChanged;
            Colour02.SettingChanged += Colours_SettingChanged;
            Colour03.SettingChanged += Colours_SettingChanged;
            Colour04.SettingChanged += Colours_SettingChanged;
            Colour05.SettingChanged += Colours_SettingChanged;
            Colour06.SettingChanged += Colours_SettingChanged;
            Colour07.SettingChanged += Colours_SettingChanged;
            Colour08.SettingChanged += Colours_SettingChanged;
            Colour09.SettingChanged += Colours_SettingChanged;
            Colour10.SettingChanged += Colours_SettingChanged;
            Colour11.SettingChanged += Colours_SettingChanged;
            Colour12.SettingChanged += Colours_SettingChanged;
            Colour13.SettingChanged += Colours_SettingChanged;
            Colour14.SettingChanged += Colours_SettingChanged;
            Colour15.SettingChanged += Colours_SettingChanged;
            Colour16.SettingChanged += Colours_SettingChanged;
            Colour17.SettingChanged += Colours_SettingChanged;
            Colour18.SettingChanged += Colours_SettingChanged;
        }

        private static void Colours_SettingChanged(object sender, EventArgs e)
        {
            GetColorPatch.color_0[0] = Colour01.Value;
            GetColorPatch.color_0[1] = Colour02.Value;
            GetColorPatch.color_0[2] = Colour03.Value;
            GetColorPatch.color_0[3] = Colour04.Value;
            GetColorPatch.color_0[4] = Colour05.Value;
            GetColorPatch.color_0[5] = Colour06.Value;
            GetColorPatch.color_0[6] = Colour07.Value;
            GetColorPatch.color_0[7] = Colour08.Value;
            GetColorPatch.color_0[8] = Colour09.Value;
            GetColorPatch.color_0[9] = Colour10.Value;
            GetColorPatch.color_0[10] = Colour11.Value;
            GetColorPatch.color_0[11] = Colour12.Value;
            GetColorPatch.color_0[12] = Colour13.Value;
            GetColorPatch.color_0[13] = Colour14.Value;
            GetColorPatch.color_0[14] = Colour15.Value;
            GetColorPatch.color_0[15] = Colour16.Value;
            GetColorPatch.color_0[16] = Colour17.Value;
            GetColorPatch.color_0[17] = Colour18.Value;
        }
    }
}