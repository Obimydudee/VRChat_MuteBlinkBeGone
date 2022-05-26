using MelonLoader;
using UnityEngine;

namespace MuteBlinkBeGoneMod
{
    public static class BuildInfo {
        public const string Name = "MuteBlinkBeGone";
        public const string Author = "Janni9009";
        public const string Company = "VRChat Modding Group";
        public const string Version = "1.2";
        public const string DownloadLink = null;
    }
    public class MuteBlinkBeGone : MelonMod {
        public override void OnLevelWasLoaded(int level) {
            /*
            | 0: Application (Fires once)
            | 1: UI (Fires once)
            | 2+: World (Fires every world change)
            */
            if (level == 1)
                GameObject.Find("UserInterface/UnscaledUI/HudContent_Old/Hud/VoiceDotParent/VoiceDotDisabled").GetComponent<FadeCycleEffect>().enabled = false;
        }
    }
}
