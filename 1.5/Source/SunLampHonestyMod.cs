using UnityEngine;
using Verse;

namespace SunLampHonesty
{
    public class SunLampHonestyMod : Mod
    {
        public const string PACKAGE_ID = "sunlamphonesty.1trickPwnyta";
        public const string PACKAGE_NAME = "Sun Lamp Honesty";

        public static SunLampHonestySettings Settings;

        public SunLampHonestyMod(ModContentPack content) : base(content)
        {
            Settings = GetSettings<SunLampHonestySettings>();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }

        public override string SettingsCategory() => PACKAGE_NAME;

        public override void DoSettingsWindowContents(Rect inRect)
        {
            base.DoSettingsWindowContents(inRect);
            SunLampHonestySettings.DoSettingsWindowContents(inRect);
        }
    }
}
