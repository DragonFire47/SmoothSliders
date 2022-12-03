using HarmonyLib;


namespace SmoothSliders
{
    [HarmonyPatch(typeof(PLUIEditableReactorEditBar), "ApplyStepping")]
    internal class PLUIEditableReactorEditBarPatch
    {
        public static bool SmoothSlidersEnabled = true;

        public static void Prefix(out float __state, float inFloat)
        {
            __state = inFloat;
        }

        public static void Postfix(float __state, ref float __result)
        {
            if(SmoothSlidersEnabled) __result = __state;
        }
    }
}
