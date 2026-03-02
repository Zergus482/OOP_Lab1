using System.Windows;
using System.Windows.Controls;
using Lab_1.Localization;

namespace Lab_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LocalizationService.ApplyLanguage("ru-RU");
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox combo &&
                combo.SelectedItem is ComboBoxItem item &&
                item.Tag is string cultureName)
            {
                LocalizationService.ApplyLanguage(cultureName);
            }
        }
    }
}