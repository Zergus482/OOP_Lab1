using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Lab_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetLanguage("ru");
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox combo &&
                combo.SelectedItem is ComboBoxItem item &&
                item.Tag is string code)
            {
                SetLanguage(code);
            }
        }

        private static void SetLanguage(string code)
        {
            var dictionaries = Application.Current.Resources.MergedDictionaries;

            var currentLangDict = dictionaries
                .FirstOrDefault(d => d.Source != null &&
                                     d.Source.OriginalString.StartsWith("Resources/Strings."));

            if (currentLangDict != null)
            {
                dictionaries.Remove(currentLangDict);
            }

            var newDict = new ResourceDictionary
            {
                Source = new Uri($"Resources/Strings.{code}.xaml", UriKind.Relative)
            };

            dictionaries.Insert(0, newDict);
        }
    }
}