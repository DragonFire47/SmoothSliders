using HarmonyLib;
using PulsarModLoader.Keybinds;
using PulsarModLoader.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSliders
{
    [HarmonyPatch(typeof(PLInGameUI), "Update")]
    internal class ToggleEnabled
    {
        static void Postfix()
        {
            if (KeybindManager.Instance.GetButtonDown("toggle_smoothsliders"))
            {
                PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled.Value = !PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled.Value;
                Messaging.Notification("Smooth Sliders " + (PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled ? "Enabled" : "Disabled"));
            }
        }
    }
}
