using PulsarModLoader;
using PulsarModLoader.Keybinds;

namespace SmoothSliders
{
    public class Mod : PulsarMod, IKeybind
    {
        public override string HarmonyIdentifier()
        {
            return "pngun.SmoothSliders";
        }

        public void RegisterBinds(KeybindManager manager)
        {
            manager.NewBind("Toggle Smooth Sliders", "toggle_smoothsliders", "Basics", "k");
        }

        public override string Author => "pngun";
        public override string ShortDescription => "Allows to set power levels on Engineering Screen more precisely";
        public override string Name => "SmoothSliders";
        public override string Version => "0.0.3";
    }
}
