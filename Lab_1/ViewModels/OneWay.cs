using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab_1.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки "Односторонние привязки" (CommunityToolkit.Mvvm).
    /// </summary>
    public partial class OneWay : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DisplayText))]
        private string _sourceText = "Исходный текст";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(DisplayText))]
        private int _sourceNumber = 200;

        [ObservableProperty]
        private string _computedValue = "Вычисленное значение";

        partial void OnSourceTextChanged(string value)
        {
            ComputedValue = $"Обработанный: {value}";
        }

        /// <summary>
        /// Вычисляемое свойство: обновляется при изменении SourceText или SourceNumber.
        /// </summary>
        public string DisplayText => $"Текст: {SourceText}, Число: {SourceNumber}";
    }
}
