using System.Windows;
using CodingSeb.Localization;
using CodingSeb.Localization.Loaders;

namespace Lab_1
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            // Подключаем загрузчик JSON и загружаем файл переводов
            LocalizationLoader.Instance.FileLanguageLoaders.Add(new JsonFileLoader());
            LocalizationLoader.Instance.AddFile("Resources/translations.loc.json");
            LocalizationLoader.Instance.AddFile("Resources/translations.extra.loc.json");

            // Язык по умолчанию
            Loc.Instance.CurrentLanguage = "ru";
        }
    }

}
