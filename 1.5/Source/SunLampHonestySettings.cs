using UnityEngine;
using Verse;

namespace SunLampHonesty
{
    public class SunLampHonestySettings : ModSettings
    {
        public static bool ClassicHydroponicsMode = false;

        public static void DoSettingsWindowContents(Rect inRect)
        {
            Listing_Standard listingStandard = new Listing_Standard();
            listingStandard.Begin(inRect);
            listingStandard.CheckboxLabeled("SunLampHonesty_ClassicHydroponicsMode".Translate(), ref ClassicHydroponicsMode);
            listingStandard.End();
        }

        public override void ExposeData()
        {
            Scribe_Values.Look(ref ClassicHydroponicsMode, "ClassicHydroponicsMode");
        }
    }
}
