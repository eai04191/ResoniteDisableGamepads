using HarmonyLib;
using ResoniteModLoader;

namespace ResoniteDisableGamepads
{
    public class ResoniteDisableGamepads : ResoniteMod
    {
        public override string Name => "ResoniteDisableGamepads";
        public override string Author => "Lexevo (Ported by Eai)";
        public override string Version => "1.0.0";
        public override string Link => "https://github.com/eai04191/ResoniteDisableGamepads/";

        public override void OnEngineInit()
        {
            Harmony harmony = new Harmony("net.mizle.ResoniteDisableGamepads");
            harmony.PatchAll();
        }

        [HarmonyPatch(typeof(FrooxEngine.StandardGamepad), "Bind")]
        class ResoniteDisableGamepadsPatch
        {
            public static bool Prefix()
            {
                return false; //dont run rest of method
            }
        }
    }
}
