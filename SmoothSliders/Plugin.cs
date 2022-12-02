using PulsarModLoader;

namespace SmoothSliders
{
    public class Plugin : PulsarMod
    {
        public override string HarmonyIdentifier()
        {
            return "pngun.SmoothSliders";
        }
        public override string Author => "pngun";
        public override string ShortDescription => "Allows to set power levels on Engineering Screen more precisely";
        public override string Name => "SmoothSliders";
        public override string Version => "0.0.3";
    }
}
