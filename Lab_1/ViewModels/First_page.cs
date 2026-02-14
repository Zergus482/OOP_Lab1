using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab_1.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки "Привязка по умолчанию" (CommunityToolkit.Mvvm).
    /// </summary>
    public partial class First_page : ObservableObject
    {
        [ObservableProperty]
        private string _textValue = "Значение по умолчанию";

        [ObservableProperty]
        private int _numberValue = 42;

        [ObservableProperty]
        private DateTime _dateValue = DateTime.Now;

        [ObservableProperty]
        private bool _isChecked = true;
    }
}
