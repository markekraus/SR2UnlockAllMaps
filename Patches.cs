using HarmonyLib;
using Il2CppMonomiPark.SlimeRancher.UI.IntroSequence;

namespace UnlockAllMaps
{
    [HarmonyPatch(typeof(IntroSequenceUIRoot), nameof(IntroSequenceUIRoot.OnDestroy))]
    internal class IntroSequenceUIRootOnDestroyPatch : Entry
    {
        public static void Postfix() =>
            UnlockAllMaps();
    }
}