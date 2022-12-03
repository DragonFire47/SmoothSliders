using PulsarModLoader.CustomGUI;
using System;
using UnityEngine;

namespace SmoothSliders
{
    internal class GUI : ModSettingsMenu
    {
        public override void Draw()
        {
            string text = "Smooth Sliders " + (PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled ? "Enabled" : "Disabled");
            bool flag = GUILayout.Button(text, Array.Empty<GUILayoutOption>());
            if (flag)
            {
                PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled.Value = !PLUIEditableReactorEditBarPatch.SmoothSlidersEnabled.Value;
            }
        }

        public override string Name()
        {
            return "SmoothSliders";
        }
    }
}
