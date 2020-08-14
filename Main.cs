using MelonLoader;
using System;
using System.Reflection;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections;
using UnhollowerRuntimeLib;
using System.Linq;
using Harmony;
using MelonLoader.Tomlyn;

namespace MuteBlinkBeGoneMod
{
    public static class BuildInfo {
        public const string Name = "MuteBlinkBeGone";
        public const string Author = "Janni9009";
        public const string Company = "VRChat Modding Group";
        public const string Version = "1.0";
        public const string DownloadLink = null;
    }
    public class MuteBlinkBeGone : MelonMod {
        public override void VRChat_OnUiManagerInit() {
            GameObject.Find("UserInterface/UnscaledUI/HudContent/Hud/VoiceDotParent/VoiceDotDisabled").GetComponent<FadeCycleEffect>().enabled = false;
        }
    }
}
