using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab_1.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки "Одноразовая привязка" (CommunityToolkit.Mvvm).
    /// </summary>
    public partial class OneTime : ObservableObject
    {
        [ObservableProperty]
        private string _initialValue = "Это значение загружается один раз";

        [ObservableProperty]
        private int _initialNumber = 100;

        [ObservableProperty]
        private string _staticText = "Статический текст";
    }
}
