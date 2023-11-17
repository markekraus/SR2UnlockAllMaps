using Il2CppMonomiPark.SlimeRancher.UI.IntroSequence;
using Il2CppMonomiPark.SlimeRancher.UI.Map;
using MelonLoader;
using UnityEngine;

namespace UnlockAllMaps
{
    internal class Entry : MelonMod
    {
        public override void OnSceneWasUnloaded(int buildIndex, string sceneName)
        {
            if (sceneName != "LoadScene")
                return;

            // skip if the intro sequence is running to prevent game crash.
            while (Resources.FindObjectsOfTypeAll<IntroSequenceUIRoot>().Count > 1)
                return;

            UnlockAllMaps();
        }

        internal static void UnlockAllMaps()
        {
            foreach (var item in Resources.FindObjectsOfTypeAll<MapNodeActivator>())
            {
                if (!item.IsZoneLocked())
                    continue;

                item.Activate();
            }
        }
    }
}
