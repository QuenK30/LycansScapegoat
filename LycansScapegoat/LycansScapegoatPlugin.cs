using BepInEx;
using LycansScapegoat.Patchs;
using UnityEngine;

namespace LycansScapegoat
{

    /**
    * Un scapegoat est un nouveau role de Lycans. Un scapegoat (Bouc émissaire) est un role villageois.
    * Il doit gagner avec le village, mais au moment des votes il doit éviter les égalités.
    * Si une égalité de vote il y a, il mourra.
    **/

    [BepInPlugin(PLUGIN_GUID, PLUGIN_NAME, PLUGIN_VERSION)]
    [BepInProcess("Lycans.exe")]
    public class LycansScapegoatPlugin : BaseUnityPlugin
    {
        public const string PLUGIN_GUID = $"quenk.lycansscapegoat";
        public const string PLUGIN_AUTHOR = "QuenK";
        public const string PLUGIN_NAME = "LycansScapegoat";
        public const string PLUGIN_VERSION = "1.0.0";
        public const string PLUGIN_FOLDER = "LycansScapegoat";
        public const string PREFIX = "LycansScapegoat > ";

        public static readonly Color ScapegoatColor = new Color(232, 255, 28, 1);

        private void Awake()
        {
            Log.Init(Logger);
            Log.Info($"{PREFIX}Loading ...");
            // TranslationsPatch.Hook();
            PlayerControllerPatch.Hook();
        }

        private void Update()
        {
        }
    }
}