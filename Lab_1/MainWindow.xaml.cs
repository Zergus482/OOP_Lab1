using System.Windows;
using System.Windows.Controls;
using CodingSeb.Localization;

namespace Lab_1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loc.Instance.CurrentLanguage = "ru";
        }

        private void LanguageComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (sender is ComboBox cb &&
                cb.SelectedItem is ComboBoxItem item &&
                item.Tag is string code)
            {
                Loc.Instance.CurrentLanguage = code;
            }
        }
    }
}