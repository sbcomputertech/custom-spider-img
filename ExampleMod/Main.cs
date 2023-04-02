using BepInEx;
using HarmonyLib;

namespace ReddustUltimatum
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    public class Main : BaseUnityPlugin
    {
        private const string ModName = "Reddust's Ultimatum";
        private const string ModAuthor  = "reddust9";
        private const string ModGuid = "com.reddust9.ultimatum";
        private const string ModVersion = "1.0.0";
        internal void Awake()
        {
            var harmony = new Harmony(ModGuid);
            harmony.PatchAll();
            Logger.LogInfo($"{ModName} successfully loaded! Made by {ModAuthor}");
        }
    }
}
