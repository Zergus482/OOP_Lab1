using CommunityToolkit.Mvvm.ComponentModel;

namespace Lab_1.ViewModels
{
    /// <summary>
    /// ViewModel для вкладки "Двухсторонняя привязка" (CommunityToolkit.Mvvm).
    /// </summary>
    public partial class Page2 : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullInfo))]
        private string _name = "Иван";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullInfo))]
        private string _surname = "Иванов";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullInfo))]
        private int _age = 25;

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FullInfo))]
        private string _email = "ivan@example.com";

        [ObservableProperty]
        private double _sliderValue = 50.0;

        /// <summary>
        /// Вычисляемое свойство: обновляется при изменении Name, Surname, Age или Email.
        /// </summary>
        public string FullInfo => $"{Name} {Surname}, {Age} лет, {Email}";
    }
}
