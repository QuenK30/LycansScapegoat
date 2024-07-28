using BepInEx;
using UnityEngine;

namespace LycansScapegoat
{

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

        private void Awake()
        {
            Log.Init(Logger);
            Log.Info($"{PREFIX}Plugin loaded");
        }

        private void Update()
        {
        }
    }
}