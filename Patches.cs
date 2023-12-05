using HarmonyLib;
using Il2CppMonomiPark.SlimeRancher.UI.Map;

namespace UnlockAllMaps
{
    [HarmonyPatch(typeof(MapNodeActivator), nameof(MapNodeActivator.Start))]
    internal class MapNodeActivatorStartPatch : Entry
    {
        public static void Postfix(MapNodeActivator __instance)
        {
            if (!__instance.IsZoneLocked())
                return;
            __instance._fogRevealEvent.RaiseEvent();
            __instance.UpdateHologramState();
        }
    }
}