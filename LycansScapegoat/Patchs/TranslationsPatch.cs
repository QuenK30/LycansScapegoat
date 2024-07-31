using UnityEngine.Localization.Settings;

namespace LycansScapegoat.Patchs
{
    public class TranslationsPatch
    {
        public static void Hook()
        {
            RegisterTranslations();
        }

        private static void RegisterTranslations()
        {
            var localizationTableEn = LocalizationSettings.StringDatabase.GetTable(
                "UI Text",
                LocalizationSettings.AvailableLocales.GetLocale("en")
            );
            var localizationTableFr = LocalizationSettings.StringDatabase.GetTable(
                "UI Text",
                LocalizationSettings.AvailableLocales.GetLocale("fr")
            );

            localizationTableEn.AddEntry("ROLE_NAME", "Scapegoat");
            localizationTableFr.AddEntry("ROLE_NAME", "Bouc émissaire");
        }
    }
}